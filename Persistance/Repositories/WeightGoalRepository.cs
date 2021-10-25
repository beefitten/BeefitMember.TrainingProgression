using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MongoDB.Driver;
using Persistance.Models;
using Persistance.Repositories.IWeightGoalRepository;
using Persistence.Settings;

namespace Persistence.Repository.WeightGoalRepository
{
    public class WeightGoalRepository : IWeightGoalRepository
    {
        private readonly IMongoCollection<WeightGoalModel> _collection;

        public WeightGoalRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<WeightGoalModel>(settings.CollectionName);
        }

        public async Task<HttpStatusCode> Create(WeightGoalModel model)
        {
            if (model == null)
                throw new Exception();
            try
            {
                await _collection.InsertOneAsync(model);
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return HttpStatusCode.Conflict;
            }
        }
    }
}