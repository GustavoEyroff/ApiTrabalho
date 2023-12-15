using AjudaAiApi.Contract.Repository;
using AjudaAiApi.Infrastructure;
using AjudaAiApii.DTO;
using AjudaAiApii.Entity;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using AjudaAiApi.Entity;

namespace AjudaAiApi.Repository
{
    public class NgoRepository : Connection, INgoRepository
    {

        public async Task Add(NgoDTO ngo)
        {
            string sql = @"INSERT INTO
                           NGO (Name, Social, Headperson, Telephone, Email, Password, City_Id, Causes_Id)
                           VALUE (@Name, @Social, @Headperson, @Telephone, @Email, @Password, @CityId, @CausesId)";
            await Execute(sql, ngo);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM NGO WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<NgoEntity>> Get()
        {
            string sql = "SELECT * FROM NGO";
            return await GetConnection().QueryAsync<NgoEntity>(sql);
        }

        public async Task<NgoEntity> GetById(int id)
        {
            string sql = "SELECT * FROM NGO WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<NgoEntity>(sql, new { id });
        }

        public async Task Update(NgoEntity ngo)
        {
            string sql = @"UPDATE NGO SET Name = @Name,
                                          Social = @Social, 
                                          HeadPerson = @HeadPerson, 
                                          Telephone = @Telephone, 
                                          Email = @Email, 
                                          Password = @Password, 
                                          City_Id = @City_Id, 
                                          Causes_Id = @Causes_Id
                                          WHERE Id = @Id";
            await Execute(sql, ngo);

        }
    }
}