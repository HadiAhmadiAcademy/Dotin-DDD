using System;
using System.Collections.Generic;
using System.Text;
using Framework.Domain;
using LoanApplications.Domain.Model.Applicants;

namespace LoanApplications.Domain.Model.LoanApplications.Events
{
    public class LoanApplicationPlaced : DomainEvent
    {
        public Guid LoanApplicationId { get; private set; }
        public ApplicantId ApplicantId { get; private set; }
        public long PackBackPeriodInDays { get; private set; }
        public long Amount { get; private set; }
        public LoanApplicationPlaced(Guid id, ApplicantId applicantId, long packBackPeriodInDays, long amount)
        {
            LoanApplicationId = id;
            ApplicantId = applicantId;
            PackBackPeriodInDays = packBackPeriodInDays;
            Amount = amount;
        }
    }
}
