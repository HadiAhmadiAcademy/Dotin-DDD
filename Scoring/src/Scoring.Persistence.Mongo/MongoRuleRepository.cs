using System;
using System.Collections.Generic;
using MongoDB.Driver;
using Scoring.Domain.Model.Rules;
using Scoring.Persistence.Mongo.Framework;

namespace Scoring.Persistence.Mongo
{
    //TODO: consider using composition instead of inheritance
    public class MongoRuleRepository : MongoRepository<Rule, int>, IRuleRepository
    {
        public MongoRuleRepository(IMongoDatabase database) : base(database) { }
        public List<Rule> FindActiveRules()
        {
            throw new NotImplementedException();
        }
    }
}
