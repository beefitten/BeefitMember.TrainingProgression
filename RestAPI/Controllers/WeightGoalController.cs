using System.Net;
using System.Threading.Tasks;
using Domain.Services;
using Domain.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("WeightGoal")]
    public class WeightGoalController : Controller
    {
        private readonly IWeightGoalService _service;

        public WeightGoalController(IWeightGoalService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("/create")]
        public async Task<HttpStatusCode> CreateWeightGoal([FromBody] CreateModel model)
        {
            return await _service.Create(model);
        }
    }
}