using AuthenticationDemo.Interface;
using AuthenticationDemo.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrict _district;

        public DistrictController(IDistrict district)
        {
            _district = district;
        }

        [Route("GetAllDistricts")]

        [HttpGet]

        public IActionResult GetAllDistricts()
        {
            return Ok(_district.GetAllDistricts());
        }


        [Route("GetDistrictById")]

        [HttpGet]

        public IActionResult GetDistrictById(int Id)
        {
            return Ok(_district.GetDistrictById(Id));
        }

        [Route("AddDistrict")]

        [HttpPost]

        public IActionResult AddDistrict(District district)
        {
            return Ok(_district.AddDistrict(district));
        }

        [Route("UpdateDistrict")]

        [HttpPut]

        public IActionResult UpdateDistrict(District district)
        {
            return Ok(_district.UpdateDistrict(district));
        }

        [Route("DeleteDistrict")]

        [HttpDelete]

        public IActionResult DeleteDistrict(int id)
        {
            return Ok(_district.DeleteDistrict(id));
        }
    }
}
