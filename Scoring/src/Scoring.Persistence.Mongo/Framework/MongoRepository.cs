using System;
using System.Collections.Generic;
using System.Text;
using Framework.Domain;
using Humanizer;
using MongoDB.Driver;

namespace Scoring.Persistence.Mongo.Framework
{
    public abstract class MongoRepository<T, TKey> where T : AggregateRoot<TKey>
    {
        protected IMongoDatabase Database;
        protected MongoRepository(IMongoDatabase database)
        {
            Database = database;
        }

        public void Add(T aggregate)
        {
            var collectionName = GetNameOfCollection();
            var collection = Database.GetCollection<T>(collectionName);
            collection.InsertOne(aggregate);
        }

        private string GetNameOfCollection()
        {
            return typeof(T).Name.Pluralize();
        }
    }
}
