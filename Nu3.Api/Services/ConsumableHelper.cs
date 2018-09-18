using System;
using System.Collections.Generic;
using MongoDB.Bson;
using Nu3.Api.Services.Interfaces;
using Nu3.Configuration;
using Nu3.Services.Interfaces;
using Nu3Core.Models;

namespace Nu3.Api.Services
{
    public class ConsumableHelper : IConsumableHelper
    {
        private readonly IDataAccessProvider _dataAccess;

        public ConsumableHelper(IDataAccessProvider dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Consumable Add(Consumable consumable)
        {
            return _dataAccess.Create(consumable, DatabaseConfiguration.ConsumableEntity);
        }

        public Consumable Get(string id)
        {
            return _dataAccess.Get<Consumable>(new ObjectId(id),DatabaseConfiguration.ConsumableEntity);
        }

        public IEnumerable<Consumable> GetAll()
        {
            return _dataAccess.GetAll<Consumable>(DatabaseConfiguration.ConsumableEntity);
        }
    }
}
