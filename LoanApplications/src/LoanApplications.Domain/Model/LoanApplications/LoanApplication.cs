using System;
using System.Collections.Generic;
using System.Text;
using Framework.Domain;
using LoanApplications.Domain.Model.Applicants;
using LoanApplications.Domain.Model.LoanApplications.Events;
using LoanApplications.Domain.Model.LoanApplications.States;

namespace LoanApplications.Domain.Model.LoanApplications
{
    public class LoanApplication : AggregateRoot<Guid>
    {
        public ApplicantId Applicant { get; private set; }
        public long PackBackPeriodInDays { get; private set; }
        public long Amount { get; private set; }
        public LoanApplicationState State { get; set; }
        public LoanApplication(ApplicantId applicantId, long packBackPeriodInDays, long amount)
        {
            this.Id = Guid.NewGuid();
            Applicant = applicantId;
            PackBackPeriodInDays = packBackPeriodInDays;
            Amount = amount;
            State = new Pending();

            Causes(new LoanApplicationPlaced(this.Id, this.Applicant, this.PackBackPeriodInDays, this.Amount));
        }
        public void Confirm()
        {
            this.State = this.State.Confirm();
            Causes(new LoanApplicationConfirmed(this.Id));
        }

        public void Cancel()
        {
            this.State = this.State.Cancel();
            Causes(new LoanApplicationCanceled(this.Id));
        }
    }
}
