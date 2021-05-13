using System.Collections.Generic;
using System.Linq;
using Scoring.Domain.Model.Applicants;
using Scoring.Domain.Model.Framework;

namespace Scoring.Domain.Model.Rules.Conditions
{
    public class JobPositionCondition : CompositeSpecification<Applicant>
    {
        private readonly List<JobPosition> _targetPositions;
        public JobPositionCondition(List<JobPosition> targetPositions)
        {
            _targetPositions = targetPositions;
        }
        public JobPositionCondition(params JobPosition[] targetPositions)
        {
            this._targetPositions = targetPositions.ToList();
        }

        public override bool IsSatisfiedBy(Applicant entity)
        {
            return _targetPositions.Contains(entity.JobPosition);
        }
    }
}
