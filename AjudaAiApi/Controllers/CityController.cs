using Microsoft.AspNetCore.Mvc;
using AjudaAiApi.Repository;
using AjudaAiApi.Contract;

namespace AjudaAiApi.Controllers
{
    [ApiController]
    [Route("City")]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cityRepository.Get());

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _cityRepository.GetByState(id));
        }

    }
}
