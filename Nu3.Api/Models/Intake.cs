using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Nu3.Enums;

namespace Nu3Core.Models
{
    public class Intake
    {        
        [BsonElement("Id")]
        public ObjectId Id { get; set; }
        
        [Required]
        [BsonElement("ConsumableId")]
        public string ConsumableId { get; set; }
        
        [Required]
        [BsonElement("UserId")]
        public string UserId { get; set; }
        
        [Required]
        [BsonElement("MealType")]
        public MealCategory MealType { get; set; }
        
        [Required]
        [BsonElement("RegisteredAt")]
        public DateTime RegisteredAt { get; set; }
        
        [Required]
        [BsonElement("Unit")]
        public Unit Unit { get; set; }
        
        [Required]
        [BsonElement("Amount")]
        public float Amount { get; set; }
        
        [Required]
        [BsonElement("Accuracy")]
        public Accuracy Accuracy { get; set; }

    }
}