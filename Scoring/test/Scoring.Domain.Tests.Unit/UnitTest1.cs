using System;
using Scoring.Domain.Model.Applicants;
using Scoring.Domain.Model.Rules;
using Scoring.Domain.Model.Rules.Conditions;
using Scoring.Domain.Model.Rules.PointCalculations;
using Xunit;

namespace Scoring.Domain.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var applicant = new Applicant()
            {
                JobPosition = JobPosition.CLevelManager,
                HireDate = new DateTime(2002, 01,01),
                PenaltyCount = 5
            };

            var condition = new HireDateCondition(new DateTime(2010,01,01))
                .And(new JobPositionCondition(JobPosition.DepartmentManager, JobPosition.CLevelManager));
            var rule = new Rule(1, "test", condition, Point.ForPenalty(10), DateRange.Always);

            var result = rule.CalculatePointsFor(applicant);
        }
    }
}
