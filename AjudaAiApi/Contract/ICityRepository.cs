using AjudaAiApi.Entity;

namespace AjudaAiApi.Contract
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityEntity>> Get();

        Task<IEnumerable<CityEntity>> GetByState(int id);
    }
}
