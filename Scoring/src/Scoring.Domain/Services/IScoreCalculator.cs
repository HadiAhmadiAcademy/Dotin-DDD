using System.Collections.Generic;
using System.Text;
using Scoring.Domain.Model.Applicants;
using Scoring.Domain.Model.Rules.PointCalculations;

namespace Scoring.Domain.Services
{
    public interface IScoreCalculator
    {
        Point CalculatePointsOf(Applicant applicant);
    }
}
