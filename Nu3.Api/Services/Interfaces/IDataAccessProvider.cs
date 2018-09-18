using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using Nu3.Models;
namespace Nu3.Services.Interfaces
{
    public interface IDataAccessProvider
    {
        IEnumerable<T> Get<T>(string entity);

        T Get<T>(ObjectId id, string entity);

        IEnumerable<T> GetList<T>(string collectionName, BsonDocument filter);

		IEnumerable<T> GetAll<T>(string collectionName);

		T Create<T>(T p, string entity);

        void Remove<T>(ObjectId id, string entity);

        bool Exists<T>(ObjectId id, string entity);
    }
}
