
namespace Domain.Services.Models
{
    public class CreateWeightGoalModel
    {
        public string ID { get; set; }
        public string user { get; set; }
        public int currentWeight { get; set; }
        public int targetWeight { get; set; }
    }
}