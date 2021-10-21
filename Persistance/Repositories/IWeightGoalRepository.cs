using System.Net;
using System.Threading.Tasks;
using Persistance.Models;

namespace Persistance.Repositories.IWeightGoalRepository {
    public interface IWeightGoalRepository {
        Task<HttpStatusCode> Create (WeightGoalModel model);
    }
}