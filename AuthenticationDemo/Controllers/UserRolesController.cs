using AuthenticationDemo.Interface;
using AuthenticationDemo.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{

    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRole _userrole;

        public UserRolesController(IUserRole userrole)
        {
            _userrole = userrole;
        }

        [Route("GetAllUserRoles")]
        [HttpGet]

        public IActionResult GetAllUserRoles()
        {
            return Ok(_userrole.GetAllUserRoles());
        }

        [Route("GetUserRoleById")]

        [HttpGet]

        public IActionResult GetUserRoleById(int Id)
        {
           return Ok(_userrole.GetUserRoleById(Id));
        }

        [Route("AddUserRole")]
        
        [HttpPost]

        public IActionResult AddUserRole(UserRole userrrole) {


            return Ok(_userrole.AddUserRole(userrrole));
        }

        [Route("UpdateUserRole")]
        
        [HttpPut]

        public IActionResult UpdateUserRole(UserRole userrrole)
        {
            return Ok(_userrole?.UpdateUserRole(userrrole));
        }

        [Route("DeleteUserRole")]
        
        [HttpDelete]

        public IActionResult DeleteUserRole(int Id)
        {
            return Ok(_userrole.DeleteUserRole(Id));
        }


    }
}
