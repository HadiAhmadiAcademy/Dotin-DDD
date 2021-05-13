using System;

namespace Scoring.Domain.Model.Applicants
{
    public class Applicant
    {
        public DateTime HireDate { get; set; }
        public JobPosition JobPosition { get; set; }
        public int PenaltyCount { get; set; }
    }
    public enum JobPosition
    {
        CLevelManager,
        DepartmentManager,
        Expert
    }
}
