using System;
using Framework;
using Framework.Application;

namespace LoanApplications.Application
{
    public class ConfirmLoanApplication : ICommand
    {
        public Guid LoanApplicationId { get; set; }
    }
}