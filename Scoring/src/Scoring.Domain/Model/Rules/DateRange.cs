using System;
using System.Collections.Generic;
using Framework.Domain;

namespace Scoring.Domain.Model.Rules
{
    public class DateRange : ValueObject
    {
        public static DateRange Always = new DateRange(null, null);
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public DateRange(DateTime? startDate, DateTime? endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        public bool IsInRange(DateTime dateTime)
        {
            //TODO: BUG - check for nullable dates
            //return this.StartDate >= dateTime && this.EndDate <= dateTime;
            return true;
        }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return StartDate;
            yield return EndDate;
        }
    }
}