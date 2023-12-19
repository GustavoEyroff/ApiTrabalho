
using AjudaAiApii.DTO;
using AjudaAiApii.Entity;
using ApiAjudaAi.DTO;

namespace AjudaAiApi.Contract.Repository
{
    public interface INgoRepository
    {

        Task Add(NgoDTO ngo);

        Task Update(NgoEntity ngo);

        Task<IEnumerable<NgoEntity>> Get();

        Task<NgoEntity> GetById(int id);

        Task Delete(int id);

        Task<NgoTokenDTO> LogIn(NgoLoginDTO ngo);

    }
}
