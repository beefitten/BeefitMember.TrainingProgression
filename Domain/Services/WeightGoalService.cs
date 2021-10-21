using System;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Domain.Services.Models;
using Persistance.Models;
using Persistance.Repositories.IWeightGoalRepository;

namespace Domain.Services {
    public class WeightGoalService : IWeightGoalService {
        private readonly IWeightGoalRepository _repository;

        async Task<HttpStatusCode> IWeightGoalService.Create (CreateModel createModel) {
            var model = new WeightGoalModel {
                ID = createModel.ID,
                user = createModel.user,
                currentWeight = createModel.currentWeight,
                targetWeight = createModel.targetWeight,
            };

            return await _repository.Create (model);
        }
    }
}