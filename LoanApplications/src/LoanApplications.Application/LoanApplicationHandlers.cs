using System.Threading.Tasks;
using Framework.Application;
using LoanApplications.Domain.Model.LoanApplications;

namespace LoanApplications.Application
{
    public class LoanApplicationHandlers : ICommandHandler<PlaceLoanApplication>
    {
        private readonly ILoanApplicationRepository _repository;
        public LoanApplicationHandlers(ILoanApplicationRepository repository)
        {
            _repository = repository;
        }
        public async Task Handle(PlaceLoanApplication command)
        {
                //TODO: remove the null and place appropriate value
            var application = new LoanApplication(null, command.PackBackPeriodInDays, command.Amount);
            await _repository.Add(application);
        }
    }
}
