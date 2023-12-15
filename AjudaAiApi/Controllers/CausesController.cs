using Microsoft.AspNetCore.Mvc;
using AjudaAiApi.Repository;
using AjudaAiApi.Contract;

namespace AjudaAiApi.Controllers
{
    [ApiController]
    [Route("Causes")]
    public class CausesController : ControllerBase
    {
        private readonly ICausesRepository _causesRepository;

        public CausesController(ICausesRepository causesRepository)
        {
            _causesRepository = causesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _causesRepository.Get());
        }

    }
}
