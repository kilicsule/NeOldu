using System;
using System.Collections.Generic;
using System.Linq;

namespace NeOldu.Data.Dal.Abstract
{
    public interface IEfDal<TEntity>
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        IQueryable<TEntity> GetQueryable();
        TEntity GetById(Guid Id);
        void Commit();
    }
}
