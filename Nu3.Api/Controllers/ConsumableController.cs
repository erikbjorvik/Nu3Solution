using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Nu3.Configuration;
using Nu3.Models;
using Nu3.Services.Interfaces;
using Nu3Core.Models;
using Nu3.Enums;
namespace Nu3.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ConsumableController : Controller
    {
        private IDataAccessProvider _dataAccessProvider;
        
        public ConsumableController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        
        [HttpPost]
        public StatusCodeResult Create([FromBody] Consumable consumable)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(422);
            }
            
            _dataAccessProvider.Create(consumable, DatabaseConfiguration.ConsumableEntity);
            return StatusCode(201);
            
        }

        [Produces("application/json")]
        [HttpGet("{id}")]
        public JsonResult Index(string id)
        {
            return Json(_dataAccessProvider.Get<Consumable>(new ObjectId(id), DatabaseConfiguration.ConsumableEntity));
        }

		[Produces("application/json")]
        [HttpGet]
		public JsonResult Index()
		{
			return Json(_dataAccessProvider.GetAll<Consumable>(DatabaseConfiguration.ConsumableEntity));
		}

		[Produces("application/json")]
		[HttpGet("category/{category}")]
        public JsonResult Category(MealCategory category)
		{
            return Json(_dataAccessProvider.GetList<Consumable>(DatabaseConfiguration.ConsumableEntity, new BsonDocument("MealCategory", category)));
		}

    }                                         
}