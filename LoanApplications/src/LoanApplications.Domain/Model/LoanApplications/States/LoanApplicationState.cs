using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplications.Domain.Model.LoanApplications.States
{
    public abstract class LoanApplicationState
    {
        public virtual LoanApplicationState Confirm()
        {
            throw new NotSupportedException();
        }
        public virtual LoanApplicationState Cancel()
        {
            throw new NotSupportedException();
        }
    }
}
