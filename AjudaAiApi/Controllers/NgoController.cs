
using AjudaAiApi.Contract.Repository;
using AjudaAiApii.DTO;
using AjudaAiApii.Entity;
using Microsoft.AspNetCore.Mvc;
using AjudaAiApi.Repository;

namespace AjudaAiApi.Controllers
{

    [ApiController]
    [Route("ngo")]
    public class NGOController : ControllerBase
    {
        private readonly INgoRepository _ngoRepository;

        public NGOController(INgoRepository ngoRepository)
        {
            _ngoRepository = ngoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(NgoDTO ngo)
        {
            await _ngoRepository.Add(ngo);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(NgoEntity ngo)
        {
            await _ngoRepository.Update(ngo);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ngoRepository.Get());

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ngoRepository.GetById(id));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _ngoRepository.Delete(id);
            return Ok();
        }
    }
}
