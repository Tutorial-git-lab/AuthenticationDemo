using AuthenticationDemo.Interface;
using AuthenticationDemo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _user;

        public UsersController(IUser user)
        {
            _user = user;
        }

        [Route("Authenticate")]

        [HttpPost]

        public IActionResult Authenticate(Login login)
        {

            var res = _user.Authenticate(login);

            if (res == null)
            {
                return Ok("Please Enter valid email and password");
            }
            else
            {

                return Ok(res);
            }
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            return Ok(_user.AddUser(user));
        }

        [HttpGet]
        public IActionResult GetAllUser()
        {
            return Ok(_user.GetAllUser());
        }
        [Route("GetUserById")]

        [HttpGet]

        public IActionResult GetUser(int Id)
        {

            return Ok(_user.GetUserById(Id));
        }

        [HttpPut]

        public IActionResult UpdateUser(User user)
        {
            return Ok(_user.UpdateUser(user));
        }


        [Route("DeleteUser")]

        [HttpDelete]

        public IActionResult DeleteUser(int Id)
        {

            return Ok(_user.DeleteUser(Id));
        }

    }
}
