using System;
using Microsoft.VisualBasic;
using MongoDB.Bson.Serialization.Attributes;

namespace Persistance.Models
{
    public class WeightGoalModel
    {
        [BsonId]
        [BsonRequired]
        [BsonElement("id")]
        public string ID { get; set; }
        
        [BsonRequired]
        [BsonElement("user")]
        public string user { get; set; }
        
        [BsonRequired]
        [BsonElement("currentWeight")]
        public int currentWeight { get; set; }
        
        [BsonRequired]
        [BsonElement("targetWeight")]
        public int targetWeight { get; set; }
        
        [BsonRequired]
        [BsonElement("timeLimit")]
        public DateFormat timeLimit { get; set; }
    }
}