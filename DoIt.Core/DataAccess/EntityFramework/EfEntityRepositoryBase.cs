using DoIt.Entities.Abstract;
using DoIt.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public readonly TContext context= new TContext();

        public EfEntityRepositoryBase()
        {
            if (context == null)
                context = new TContext();
        }

        public TEntity Add(TEntity entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList<TEntity>() : context.Set<TEntity>().Where(filter).ToList<TEntity>();
        }

        public TEntity Update(TEntity entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            (entity as BaseEntity).UpdateDate = DateTime.Now;
            context.SaveChanges();
            return entity;
        }
    }
}
