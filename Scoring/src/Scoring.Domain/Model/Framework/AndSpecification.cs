namespace Scoring.Domain.Model.Framework
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _left;
        private ISpecification<T> _right;
        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return _left.IsSatisfiedBy(entity) && 
                   _right.IsSatisfiedBy(entity);
        }
    }
}
