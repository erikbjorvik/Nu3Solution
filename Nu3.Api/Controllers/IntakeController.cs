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

namespace Nu3.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class IntakeController : Controller
    {
        private IDataAccessProvider _dataAccessProvider;
        
        public IntakeController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        
        [HttpPost]
        public StatusCodeResult Create([FromBody] Intake intake)
        {
            
            if (!ModelState.IsValid)
            {
                return StatusCode(422);
            }
            
            if (!_dataAccessProvider.Exists<User>(new ObjectId(intake.UserId), DatabaseConfiguration.UsersEntity))
            {
                return StatusCode(406);
            }
            
            _dataAccessProvider.Create(intake, DatabaseConfiguration.IntakeEntity);
            return StatusCode(201);
            
        }
        
        [Produces("application/json")]
        [HttpGet("{id}")]
        public JsonResult Index(string id)
        {
            return Json(_dataAccessProvider.Get<Intake>(new ObjectId(id), DatabaseConfiguration.IntakeEntity));
        }

    }                                         
}