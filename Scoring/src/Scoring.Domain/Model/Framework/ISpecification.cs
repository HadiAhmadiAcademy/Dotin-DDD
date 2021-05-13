namespace Scoring.Domain.Model.Framework
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
