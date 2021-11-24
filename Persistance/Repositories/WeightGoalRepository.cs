using System;
using System.Net;
using System.Threading.Tasks;
using MongoDB.Driver;
using Persistance.Models;
using Persistence.Repositories.WeightGoalRepository;
using Persistence.Settings;

namespace Persistance.Repositories
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
                Console.WriteLine("++++++++++++++++++++++++++++\n" + e + "\n++++++++++++++++++++++++++++");
                return HttpStatusCode.Conflict;
            }
        }

        public async Task<ReturnModel> Get(string user)
        {
            if (user == null)
                return null;

            try
            {
                var response = await _collection
                    .Find<WeightGoalModel>(item => item.ID == user)
                    .FirstOrDefaultAsync();

                var model = new ReturnModel
                {
                    User = response.ID,
                    CurrentWeight = response.CurrentWeight,
                    TargetWeight = response.TargetWeight
                };

                return model;
            }
            catch (Exception e)
            {
                Console.WriteLine("++++++++++++++++++++++++++++\n" + e + "\n++++++++++++++++++++++++++++");
                return null;
            }
        }

        public async Task<HttpStatusCode> Delete(string user)
        {
            if (user == null)
                return HttpStatusCode.Conflict;

            try
            {
                var model = await _collection
                    .Find<WeightGoalModel>(item => item.ID == user)
                    .FirstOrDefaultAsync();

                if (model == null)
                    return HttpStatusCode.Conflict;
                
                var filter = Builders<WeightGoalModel>.Filter.Eq(person => person.ID, user);
                
                await _collection.DeleteOneAsync(filter);

                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                return HttpStatusCode.Conflict;
            }
        }
    }
}