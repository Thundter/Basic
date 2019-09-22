using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Basic.DataAccess
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected string _connectionString;

        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract TEntity Select(int id);
        public abstract IEnumerable<TEntity> Select();

        public abstract TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        public abstract IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        public abstract void Add(TEntity entity);
        public abstract void AddRange(IEnumerable<TEntity> entities);

        public abstract void Remove(TEntity entity);
        public abstract void RemoveRange(IEnumerable<TEntity> entities);
    }
}
