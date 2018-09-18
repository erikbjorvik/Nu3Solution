using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Nu3.Models
{
    public class User
    {
        
        public ObjectId Id { get; set; }
        
        [BsonElement("SocialSecurityNumber")]
        [Required]
        [StringLength(11)]
        public String SocialSecurityNumber { get; set; }
        
        [BsonElement("Firstname")]
        [Required]
        [StringLength(100)]
        public String Firstname { get; set; }
        
        [BsonElement("Lastname")]
        [Required]
        [StringLength(100)]
        public String Lastname { get; set; }

    }
}
