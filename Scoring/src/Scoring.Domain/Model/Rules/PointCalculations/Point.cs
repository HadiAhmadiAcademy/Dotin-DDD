using System;
using System.Collections.Generic;
using Framework.Domain;

namespace Scoring.Domain.Model.Rules.PointCalculations
{
    public class Point : ValueObject
    {
        public static Point NoPoint = new Point(0);
        public int Value { get; private set; }
        private Point(int value)
        {
            this.Value = value;
        }
        public static Point ForReward(int value)
        {
            return new Point(Math.Abs(value));
        }
        public static Point ForPenalty(int value)
        {
            return new Point(-Math.Abs(value));
        }

        public static Point operator +(Point left, Point right)
        {
            return new Point(left.Value + right.Value);
        }
        public static Point operator -(Point left, Point right)
        {
            return new Point(left.Value - right.Value);
        }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }
    }
}
