namespace LoanApplications.Domain.Model.LoanApplications.States
{
    public class Pending : LoanApplicationState
    {
        public override LoanApplicationState Confirm()
        {
            return new Confirmed();
        }

        public override LoanApplicationState Cancel()
        {
            return new Cancelled();
        }
    }
}