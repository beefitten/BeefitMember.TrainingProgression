using System;
using Microsoft.VisualBasic;
using MongoDB.Bson.Serialization.Attributes;

namespace Persistance.Models
{
    public class WeightGoalModel
    {
        [BsonId]
        [BsonRequired]
        [BsonElement("ID")]
        public string ID { get; set; }

        [BsonRequired]
        [BsonElement("CurrentWeight")]
        public int CurrentWeight { get; set; }

        [BsonRequired]
        [BsonElement("TargetWeight")]
        public int TargetWeight { get; set; }
    }
}