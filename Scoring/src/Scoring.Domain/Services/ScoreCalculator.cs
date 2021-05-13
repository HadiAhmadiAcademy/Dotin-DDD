using System;
using System.Linq;
using Scoring.Domain.Model.Applicants;
using Scoring.Domain.Model.Rules;
using Scoring.Domain.Model.Rules.PointCalculations;

namespace Scoring.Domain.Services
{
    public class ScoreCalculator : IScoreCalculator
    {
        private IRuleRepository _rules;
        public Point CalculatePointsOf(Applicant applicant)
        {
            var activeRules = _rules.FindActiveRules();
            return activeRules
                .Select(a=> a.CalculatePointsFor(applicant))
                .Where(a=> a != Point.NoPoint)
                .Aggregate((a,b)=> a + b);          //If there is any performance issue, consider
                                                    // using Sum on primitive values of value object
        }
    }
}