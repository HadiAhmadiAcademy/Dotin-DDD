using System;
using Framework.Application;

namespace LoanApplications.Application
{
    public class RejectLoanApplication : ICommand
    {
        public Guid LoanApplicationId { get; set; }
    }
}