using AjudaAiApi.Entity;

namespace AjudaAiApi.Contract
{
    public interface IStateRepository
    {
        Task<IEnumerable<StateEntity>> Get();
    }
}
