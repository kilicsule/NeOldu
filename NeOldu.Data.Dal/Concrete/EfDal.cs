using Microsoft.EntityFrameworkCore;
using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeOldu.Data.Dal.Concrete
{
    public class EfDal<TEntity> : IEfDal<TEntity> where TEntity : BaseEntity<Guid>
    {
        protected NeOlduDbContext Context;
        private DbSet<TEntity> dbSet;

        public DbSet<TEntity> DbSet
        {
            get { return dbSet; }
            set { dbSet = value; }
        }

        public EfDal(NeOlduDbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public TEntity GetById(Guid Id)
        {
            return dbSet.Where(p => p.Id == Id).FirstOrDefault();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return DbSet as IQueryable<TEntity>;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
