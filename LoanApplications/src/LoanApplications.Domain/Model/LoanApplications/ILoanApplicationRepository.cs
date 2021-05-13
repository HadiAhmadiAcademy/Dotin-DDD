using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanApplications.Domain.Model.LoanApplications
{
    public interface ILoanApplicationRepository
    {
        Task Add(LoanApplication aggregate);
        Task<LoanApplication> Find(Guid id);
    }
}
