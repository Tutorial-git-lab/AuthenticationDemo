using AuthenticationDemo.Interface;
using AuthenticationDemo.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountry _country;

        public CountryController(ICountry country)
        {
            _country = country;
        }

        [Route("GetAllCountries")]

        [HttpGet]

        public IActionResult GetAllCountries()
        {
            return Ok(_country.GetAllCountries());
        }

        [Route("GetDistrictById")]

        [HttpGet]

        public IActionResult GetCountryById(int Id)
        {
            return Ok(_country.GetCountryById(Id));
        }

        [Route("AddCountry")]

        [HttpPost]

        public IActionResult AddCountry(Country country)
        {
            return Ok(_country.AddCountry(country));
        }

        [Route("UpdateCountry")]

        [HttpPut]

        public IActionResult UpdateCountry(Country country)
        {
            return Ok(_country.UpdateCountry(country));
        }

        [Route("DeleteCountry")]

        [HttpDelete]

        public IActionResult DeleteCountry(int Id)
        {
            return Ok(_country.DeleteCountry(Id));
        }
    }
}
