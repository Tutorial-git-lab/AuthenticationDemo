using AuthenticationDemo.Interface;
using AuthenticationDemo.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRole _role;

        public RolesController(IRole role)
        {
            _role = role;
        }

        [Route("GetAllRoles")]
        [HttpGet]
        
        public IActionResult GetAllRoles()
        {
            return Ok(_role.GetAllRoles());
        }

        
        [Route("GetRoleById")]
        [HttpGet]
        
        public IActionResult GetRoleById(int Id)
        {
            return Ok(_role.GetRoleById(Id));
        }

        [Route("AddRole")]
        [HttpPost]

        public IActionResult AddRole(Role role)
        {
            return Ok(_role.AddRole(role));
        }

        [Route("UpdateRole")]
        [HttpPut]
        public IActionResult UpdateRole(Role role)
        {
            return Ok(_role.UpdateRole(role));

        }


        [Route("DeleteRole")]
        [HttpDelete]

        public IActionResult DeleteRole(int Id)
        {
            return Ok(_role.DeleteRole(Id));
        }
        
    }
}
