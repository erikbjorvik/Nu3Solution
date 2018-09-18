using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Nu3.Models
{
    public class PredefinedMeal
    {
		//[BsonElement("Id")]
		public String Id { get; set; }

		[Required]
		//[BsonElement("Name")]
		public string Name { get; set; }

		[Required]
		//[BsonElement("ImagePath")]
		public string ImagePath { get; set; }

    }
}
