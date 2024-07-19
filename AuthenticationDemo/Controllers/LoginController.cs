using AuthenticationDemo.Data;
using AuthenticationDemo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationDemo.Controllers
{

    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;

        public LoginController(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }

        [HttpPost]

        public ActionResult Login(Login login)
        {
            var user=_context.Users.FirstOrDefault(x=>x.Email == login.UserId && x.Password == login.Password);
            var roleid = _context.UserRoles.FirstOrDefault(x => x.UserId == user.Id).RoleId;
            var rolename = _context.Roles.FirstOrDefault(x => x.Id == roleid).RoleName;

            if(user != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials=new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Email),
                    new Claim(ClaimTypes.Role,rolename)

                };
                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Audience"],
                        claims, expires: DateTime.Now.AddMinutes(15),
                        signingCredentials: credentials);
                return Ok(new JwtSecurityTokenHandler().WriteToken(token));


            }
            return NotFound("userNotFound");
        }
    }
   
}
