using Microsoft.AspNetCore.Mvc;
using AjudaAiApi.Repository;
using AjudaAiApi.Contract;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _stateRepository.Get());
        }
    }
}
