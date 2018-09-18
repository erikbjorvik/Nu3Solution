using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Nu3.Enums;

namespace Nu3Core.Models
{
    public class Nutrients
    {

		[BsonElement("Accuracy")]
        public Accuracy Accuracy { get; set; }

        [BsonElement("Water")]
        public float Water { get; set; }
        
        [BsonElement("EdiblePart")]
        public float EdiblePart { get; set; }
        
        [BsonElement("Kilojoules")]
        public float Kilojoules { get; set; }
        
        [BsonElement("Kilocalories")]
        public float Kilocalories { get; set; }
        
        [BsonElement("DietaryFibre")]
        public float DietaryFibre { get; set; }
        
        [BsonElement("Protein")]
        public float Protein { get; set; }
        
        [BsonElement("Alcohol")]
        public float Alcohol { get; set; }
        
        [BsonElement("Fat")]
        public float Fat { get; set; }
        
        [BsonElement("Carbohydrate")]
        public float Carbohydrate { get; set; }
        
        [BsonElement("Vitamins")]
        public List<Vitamin> Vitamins { get; set; }
        
        [BsonElement("Minerals")]
        public IEnumerable<Mineral> Minerals { get; set; }

    }
}