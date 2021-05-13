using System;
using System.Collections.Generic;
using System.Text;
using Framework.Domain;

namespace LoanApplications.Domain.Model.LoanApplications.Events
{
    public class LoanApplicationCanceled : DomainEvent
    {
        public Guid LoanApplicationId { get; private set; }
        public LoanApplicationCanceled(Guid loanApplicationId)
        {
            LoanApplicationId = loanApplicationId;
        }
    }
}
