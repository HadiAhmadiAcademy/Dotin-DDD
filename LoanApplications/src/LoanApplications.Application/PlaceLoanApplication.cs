using System.Collections.Generic;
using System.Text;
using Framework.Application;

namespace LoanApplications.Application
{
    public class PlaceLoanApplication : ICommand
    {
        public long ApplicantId { get; set; }
        public long PackBackPeriodInDays { get; set; }
        public long Amount { get; set; }
    }
}
