using System;
using System.Collections.Generic;
using System.Text;
using Framework.Domain;
using Microsoft.Win32.SafeHandles;

namespace LoanApplications.Domain.Model.Applicants
{
    public class Applicant : AggregateRoot<ApplicantId>
    {
        public string Firstname { get;private  set; }
        public string Lastname { get; private set; }
        public Applicant(ApplicantId id, string firstname, string lastname)
        {
            this.Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }

    public class ApplicantId : ValueObject
    {
        public int Value { get; private set; }
        public ApplicantId(int value)
        {
            Value = value;
        }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return this.Value;
        }
    }
}
