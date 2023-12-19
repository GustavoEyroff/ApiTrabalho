
using AjudaAiApi.Contract.Repository;
using AjudaAiApii.DTO;
using AjudaAiApii.Entity;
using Microsoft.AspNetCore.Mvc;
using AjudaAiApi.Repository;
using Microsoft.AspNetCore.Authorization;
using ApiAjudaAi.DTO;

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
        [Authorize(Roles = "default")]

        public async Task<IActionResult> Add(NgoDTO ngo)
        {
            await _ngoRepository.Add(ngo);
            return Ok();
        }
     
        [HttpPut]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Update(NgoEntity ngo)
        {
            await _ngoRepository.Update(ngo);
            return Ok();
        }
      
        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ngoRepository.Get());

        }
      
        [HttpGet("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ngoRepository.GetById(id));
        }
        
        [HttpDelete]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ngoRepository.Delete(id);
            return Ok();
        }
      
        [HttpPost]
        [Route("login")]
        [Authorize(Roles = "default")]

        public async Task<IActionResult> Login(NgoLoginDTO user)
        {
            try
            {


                return Ok(await _ngoRepository.LogIn(user));
            }
            catch (Exception ex)
            {
                return Unauthorized("Usuário ou senha inválidos");
            }
        }

    }
}
