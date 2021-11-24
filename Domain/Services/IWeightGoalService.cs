using System.Net;
using System.Threading.Tasks;
using Domain.Services.Models;
using Persistance.Repositories;

namespace Domain.Services
{
    public interface IWeightGoalService
    {
        Task<HttpStatusCode> Create(CreateWeightGoalModel model);
        Task<ReturnModel> Get(string user);
        Task<HttpStatusCode> Delete(string user);
    }
}