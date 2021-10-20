using System.Net;
using System.Threading.Tasks;
using Domain.Services.Models;

namespace Domain.Services {
    public class WeightGoalService : IWeightGoalService {
        Task<HttpStatusCode> IWeightGoalService.Create (CreateModel model) {
            throw new System.NotImplementedException ();
        }
    }
}