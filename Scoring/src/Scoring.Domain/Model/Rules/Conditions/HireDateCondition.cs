using System;
using Scoring.Domain.Model.Applicants;
using Scoring.Domain.Model.Framework;

namespace Scoring.Domain.Model.Rules.Conditions
{
    public class HireDateCondition : CompositeSpecification<Applicant>
    {
        private readonly DateTime _hireDate;
        public HireDateCondition(DateTime hireDate)
        {
            _hireDate = hireDate;
        }

        public override bool IsSatisfiedBy(Applicant entity)
        {
            //TODO: enable passing operator from client
            
            return entity.HireDate < _hireDate;
        }
    }
}
