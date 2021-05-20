using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanApplications.Domain.Model.LoanApplications;

namespace LoanApplications.Config.Fakes
{
    public class InMemoryLoanApplicationRepository : ILoanApplicationRepository
    {
        private List<LoanApplication> entities = new List<LoanApplication>();
        public Task Add(LoanApplication aggregate)
        {
            entities.Add(aggregate);
            return Task.CompletedTask;
        }

        public Task<LoanApplication> Find(Guid id)
        {
            var item = entities.FirstOrDefault(a => a.Id == id);
            return Task.FromResult(item);
        }
    }
}
