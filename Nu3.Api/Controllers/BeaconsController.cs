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

namespace Nu3.Controllers
{
    [Produces("application/json")]
    [Route("api/beacons")]
    public class BeaconsController : Controller
    {
        private IDataAccessProvider _dataAccessProvider;
        
        public BeaconsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpPost]
        public StatusCodeResult Create([FromBody] Beacon beacon)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(422);
            }
            
            _dataAccessProvider.Create(beacon, DatabaseConfiguration.BeaconsEntity);
            return StatusCode(201);
            
        }
        
        [Produces("application/json")]
        [HttpGet("{id}")]
        public JsonResult Index(string id)
        {
            ObjectId beaconId = new ObjectId(id);
            return Json(_dataAccessProvider.Get<Beacon>(beaconId, DatabaseConfiguration.BeaconsEntity));
        }

		[Produces("application/json")]
		public JsonResult Index()
		{
			return Json(_dataAccessProvider.Get<Beacon>(DatabaseConfiguration.BeaconsEntity));
		}

    }                                         
}