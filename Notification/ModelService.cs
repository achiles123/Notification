using MongoDB.Driver;
using Notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification
{
    public class ModelService<T> where T:Model
    {
        IMongoCollection<T> collection;
        T model;

        public ModelService(IMongoDb settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            model = (T)Activator.CreateInstance(typeof(T));
            collection = database.GetCollection<T>(model.CollectionName);
        }

        public List<T> Get() =>
            collection.Find(f => true).ToList();

        public T Get(string id) =>
            collection.Find<T>(f => f.Id == id).FirstOrDefault();

        public T Create(T obj)
        {
            collection.InsertOne(obj);
            return obj;
        }

        public void Update(string id, T objIn)
        {
            collection.ReplaceOne(f => f.Id == id, objIn);
        }

        public void Remove(T objIn)
        {
            collection.DeleteOne(f => f.Id == objIn.Id);
        }

        public void Remove(string id)
        {
            collection.DeleteOne(f => f.Id == id);
        }
    }
}
