using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Nu3.Configuration;
using Nu3.Services.Interfaces;

namespace Nu3.Services
{
    public class MongoAccess : IDataAccessProvider
    {
        private MongoClient _client;
        private IMongoDatabase _db;
 
        public MongoAccess()
        {
            _client = new MongoClient(DatabaseConfiguration.DBConnectionString);
            _db = _client.GetDatabase(DatabaseConfiguration.DBName);
        }
 
        public IEnumerable<T> Get<T>(string collectionName)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var result = collection.Find(new BsonDocument()).ToList();

            return result;
        }

        public IEnumerable<T> GetList<T>(string collectionName, BsonDocument filter)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var result = collection.Find(filter).ToList();

            return result;
        }

        public IEnumerable<T> GetAll<T>(string collectionName)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var result = collection.Find(new BsonDocument()).ToList();

            return result;
        }
 
        public T Get<T>(ObjectId id, string collectionName)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var filter = new BsonDocument("_id", id);
            var result = collection.Find(filter).First<T>();

            return result;
        }
 
        public T Create<T>(T p, string collectionName)
        {
            _db.GetCollection<T>(collectionName).InsertOne(p);
            return p;
        }
 
        public void Update<T>(ObjectId id, string collectionName, T replacement)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var filter = new BsonDocument("_id", id);
            var result = collection.FindOneAndReplace(filter, replacement);
        }

        public void Remove<T>(ObjectId id, string collectionName)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var filter = new BsonDocument("_id", id);
            var result = collection.DeleteOne(filter);
        }

        public bool Exists<T>(ObjectId id, string collectionName)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var filter = new BsonDocument("_id", id);
            return collection.Find(filter).Any<T>();
        }
    }
}