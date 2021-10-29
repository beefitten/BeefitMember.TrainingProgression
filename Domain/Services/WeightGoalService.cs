using System.Net;
using System.Threading.Tasks;
using Domain.Services.Models;
using Persistance.Models;
using Persistance.Repositories;
using Persistence.Repositories.WeightGoalRepository;

namespace Domain.Services
{
    public class WeightGoalService : IWeightGoalService
    {
        private readonly IWeightGoalRepository _repository;

        public WeightGoalService(IWeightGoalRepository weightGoalRepository)
        {
            _repository = weightGoalRepository;
        }

        public async Task<HttpStatusCode> Create(CreateWeightGoalModel createModel)
        {
            var model = new WeightGoalModel
            {
                ID = createModel.User,
                CurrentWeight = createModel.CurrentWeight,
                TargetWeight = createModel.TargetWeight,
            };

            return await _repository.Create(model);
        }

        public async Task<ReturnModel> Get(string user)
        {
            return await _repository.Get(user);
        }

        public async Task<HttpStatusCode> Delete(string user)
        {
            return await _repository.Delete(user);
        }
    }
}