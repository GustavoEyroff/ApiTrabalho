using AjudaAiApi.Entity;

namespace AjudaAiApi.Contract
{
    public interface ICausesRepository
    {
        Task<IEnumerable<CausesEntity>> Get();
    }
}
