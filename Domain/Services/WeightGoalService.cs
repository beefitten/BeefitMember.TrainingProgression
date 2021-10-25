using System;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Domain.Services.Models;
using Persistance.Models;
using Persistance.Repositories.IWeightGoalRepository;

namespace Domain.Services
{
    public class WeightGoalService : IWeightGoalService
    {
        private readonly IWeightGoalRepository _repository;

        public WeightGoalService(IWeightGoalRepository weightGoalRepository)
        {
            _repository = weightGoalRepository;
        }

        public async Task<HttpStatusCode> Create(CreateModel createModel)
        {
            var model = new WeightGoalModel
            {
                ID = createModel.ID,
                User = createModel.user,
                CurrentWeight = createModel.currentWeight,
                TargetWeight = createModel.targetWeight,
            };

            return await _repository.Create(model);
        }
    }
}