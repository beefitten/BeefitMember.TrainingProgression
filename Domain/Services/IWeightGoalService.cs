using System.Net;
using System.Threading.Tasks;
using Domain.Services.Models;

namespace Domain.Services
{
    public interface IWeightGoalService
    {
        Task<HttpStatusCode> Create(CreateWeightGoalModel model);
    }
}