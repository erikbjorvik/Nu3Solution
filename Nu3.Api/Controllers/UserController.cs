using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Diagnostics;
using MongoDB.Bson;
using Nu3.Configuration;
using Nu3.Models;
using Nu3.Services;
using Nu3.Services.Interfaces;

namespace Nu3.Controllers
{
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : Controller
    {
        private IDataAccessProvider _dataAccessProvider;

        public UserController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpPost]
        public StatusCodeResult Create([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(422);
            }
            
            _dataAccessProvider.Create(user, DatabaseConfiguration.UsersEntity);
            return StatusCode(201);
            
        }
        
        [Produces("application/json")]
        [HttpGet("{id}")]
        public JsonResult Index(string id)
        {
            ObjectId userId = new ObjectId(id);
            return Json(_dataAccessProvider.Get<User>(userId, DatabaseConfiguration.UsersEntity));
        }
        
    }
}