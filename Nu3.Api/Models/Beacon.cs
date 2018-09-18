using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Nu3.Models
{
    public class Beacon
    {
        [BsonElement("Id")]
        public ObjectId Id { get; set; }
        
        [BsonElement("UUID")]
        public String UUID { get; set; }
        
        [BsonElement("Description")]
        [StringLength(100)]
        public String Description { get; set; }
        
    }
}