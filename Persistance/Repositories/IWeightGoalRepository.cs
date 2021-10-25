using System.Net;
using System.Threading.Tasks;
using Persistance.Models;

namespace Persistence.Repositories.WeightGoalRepository
{
    public interface IWeightGoalRepository
    {
        Task<HttpStatusCode> Create(WeightGoalModel model);
    }
}