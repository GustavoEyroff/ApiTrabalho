using Microsoft.AspNetCore.Mvc;
using AjudaAiApi.Repository;
using AjudaAiApi.Contract;

namespace AjudaAiApi.Controllers
{
    [ApiController]
    [Route("State")]
    public class StateController : ControllerBase
    {
        private readonly IStateRepository _stateRepository;

        public StateController(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _stateRepository.Get());
        }
    }
}
