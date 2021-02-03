using System;

namespace Neoldu.Data.Domain.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
    public class BaseEntity<TEntity> : IEntity<TEntity>
    {
        public TEntity Id { get; set; }
    }

    public class BaseGuidEntity : BaseEntity<Guid>
    {

    }
}
