using System;
using System.Collections.Generic;
using MongoDB.Bson;
using Nu3Core.Models;

namespace Nu3.Api.Services.Interfaces
{
    public interface IConsumableHelper
    {
		Consumable Get(string id);

		IEnumerable<Consumable> GetAll();

        Consumable Add(Consumable consumable);
    }
}
