using System;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Scoring.Domain.Model.Applicants;
using Scoring.Domain.Model.Framework;
using Scoring.Domain.Model.Rules;
using Scoring.Domain.Model.Rules.Conditions;
using Scoring.Domain.Model.Rules.PointCalculations;
using Xunit;

namespace Scoring.Persistence.Mongo.Tests.Integration
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var client = new MongoClient("mongodb://root:changeit@192.168.39.31");
            var database = client.GetDatabase("Scoring");
            var repository = new MongoRuleRepository(database);

            RegisterMappings();

            var conditions = new JobPositionCondition(JobPosition.CLevelManager)
                .And(new HireDateCondition(DateTime.Now));
            var rule = new Rule(1, "test rule", conditions, Point.ForReward(10),DateRange.Always);

            repository.Add(rule);

            //.........
        }

        private void RegisterMappings()
        {
            //TODO: fix this
            BsonClassMap.RegisterClassMap<CompositeSpecification<Applicant>>(map =>
            {
                map.AutoMap();
                map.SetIsRootClass(true);

                map.AddKnownType(typeof(JobPositionCondition));
                map.AddKnownType(typeof(HireDateCondition));
                map.AddKnownType(typeof(AndSpecification<Applicant>));
                map.AddKnownType(typeof(OrSpecification<Applicant>));
            });
        }
    }
}
