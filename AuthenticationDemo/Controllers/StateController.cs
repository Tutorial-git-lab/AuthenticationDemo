using AuthenticationDemo.Interface;
using AuthenticationDemo.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IState _state;

        public StateController(IState state)
        {
            _state = state;
        }

        [Route("GetAllStates")]

        [HttpGet]

        public IActionResult GetAllStates()
        {
            return Ok(_state.GetAllStates());
        }

        [Route("GetStateById")]

        [HttpGet]

        public IActionResult GetStateById(int Id)
        {
            return Ok(_state.GetStateById(Id));
        }

        [Route("AddState")]

        [HttpPost]

        public IActionResult AddState(State state)
        {
            return Ok(_state.AddState(state));
        }

        [Route("UpdateState")]

        [HttpPut]

        public IActionResult UpdateState(State state)
        {
            return Ok(_state.UpdateState(state));
        }

        [Route("DeleteState")]

        [HttpDelete]

        public IActionResult DeleteState(int Id)
        {
            return Ok(_state.DeleteState(Id));
        }

    }

    

    
}
