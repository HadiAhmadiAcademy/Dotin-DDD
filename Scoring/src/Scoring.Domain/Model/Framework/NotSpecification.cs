namespace Scoring.Domain.Model.Framework
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _target;
        public NotSpecification(ISpecification<T> target)
        {
            _target = target;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return !_target.IsSatisfiedBy(entity);
        }
    }
}
