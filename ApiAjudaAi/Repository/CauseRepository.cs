using AjudaAiApi.Contract;
using AjudaAiApi.Entity;
using AjudaAiApi.Infrastructure;
using Dapper;

namespace AjudaAiApi.Repository
{
    public class CausesRepository : Connection, ICausesRepository
    {
        public async Task<IEnumerable<CausesEntity>> Get()
        {
            string sql = "SELECT * FROM CAUSES";
            return await GetConnection().QueryAsync<CausesEntity>(sql);
        }
    }
}