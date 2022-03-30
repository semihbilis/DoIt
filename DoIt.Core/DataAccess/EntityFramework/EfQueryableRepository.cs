using DoIt.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<TEntity,TContext> : IQueryableRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public readonly TContext _context;
        public IDbSet<TEntity> _entities;
        public EfQueryableRepository()
        {
            if (_context == null)
                _context = new TContext();
        }
        public IQueryable<TEntity> Table => this.Entities;
        protected virtual IDbSet<TEntity> Entities => _entities ?? (_entities = _context.Set<TEntity>());
    }
}
