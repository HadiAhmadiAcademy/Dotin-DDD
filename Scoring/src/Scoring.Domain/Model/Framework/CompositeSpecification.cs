namespace Scoring.Domain.Model.Framework
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public AndSpecification<T> And(ISpecification<T> right)
        {
            return new AndSpecification<T>(this, right);
        }
        public OrSpecification<T> Or(ISpecification<T> right)
        {
            return new OrSpecification<T>(this, right);
        }
        public NotSpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }
        public abstract bool IsSatisfiedBy(T entity);
    }
}
