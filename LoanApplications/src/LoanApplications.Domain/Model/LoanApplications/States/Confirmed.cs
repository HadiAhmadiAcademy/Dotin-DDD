namespace LoanApplications.Domain.Model.LoanApplications.States
{
    public class Confirmed : LoanApplicationState
    {
        public override LoanApplicationState Cancel()
        {
            return new Cancelled();
        }
    }
}