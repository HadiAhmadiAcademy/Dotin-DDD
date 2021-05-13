using System;
using Framework.Domain;
using Scoring.Domain.Model.Applicants;
using Scoring.Domain.Model.Framework;
using Scoring.Domain.Model.Rules.PointCalculations;

namespace Scoring.Domain.Model.Rules
{
    public class Rule : AggregateRoot<int>
    {
        public string Title { get; private set; }
        public ISpecification<Applicant> Condition { get; private set; }
        public Point ResultPoint { get; private set; }
        public DateRange ActivePeriod { get; private set; }
        public Rule(int id, string title, ISpecification<Applicant> condition, Point points, DateRange activePeriod)
        {
            Id = id;
            Title = title;
            Condition = condition;
            ResultPoint = points;
            ActivePeriod = activePeriod;
        }
        public Point CalculatePointsFor(Applicant applicant)
        {
            if (!ActivePeriod.IsInRange(DateTime.Now)) return Point.NoPoint;

            if (Condition.IsSatisfiedBy(applicant))
                return ResultPoint;
            return Point.NoPoint;
        }
    }
}
