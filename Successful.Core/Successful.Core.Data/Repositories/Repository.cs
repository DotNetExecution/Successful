using System;
using Successful.Core.Domain.Entities;

namespace Successful.Core.Data.Repositories
{
    public class Repository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        public virtual TEntity Get(TPrimaryKey primaryKey)
        {
            throw new NotImplementedException();
        }
    }
}
