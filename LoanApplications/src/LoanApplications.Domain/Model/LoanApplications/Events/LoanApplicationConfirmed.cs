using System;
using System.Collections.Generic;
using System.Text;
using Framework.Domain;

namespace LoanApplications.Domain.Model.LoanApplications.Events
{
    public class LoanApplicationConfirmed : DomainEvent
    {
        public Guid LoanApplicationId { get; private set; }
        public LoanApplicationConfirmed(Guid loanApplicationId)
        {
            LoanApplicationId = loanApplicationId;
        }
    }
}
