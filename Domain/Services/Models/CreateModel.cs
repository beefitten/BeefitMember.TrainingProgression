
using System;

namespace Domain.Services.Models
{
    public class CreateWeightGoalModel
    {
        public string User { get; set; }
        public int CurrentWeight { get; set; }
        public int TargetWeight { get; set; }
    }
}