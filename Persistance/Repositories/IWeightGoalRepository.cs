using System.Net;
using System.Threading.Tasks;
using Persistance.Models;
using Persistance.Repositories;

namespace Persistence.Repositories.WeightGoalRepository
{
    public interface IWeightGoalRepository
    {
        Task<HttpStatusCode> Create(WeightGoalModel model);
        Task<ReturnModel> Get(string user);
        Task<HttpStatusCode> Delete(string user);
    }
}