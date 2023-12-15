using AjudaAiApi.Contract;
using AjudaAiApi.Infrastructure;
using Dapper;
using AjudaAiApi.Entity;


namespace AjudaAiApi.Repository
{
    public class StateRepository : Connection, IStateRepository
    {
        public async Task<IEnumerable<StateEntity>> Get()
        {
            string sql = "SELECT * FROM STATE";
            return await GetConnection().QueryAsync<StateEntity>(sql);
        }
    }
}