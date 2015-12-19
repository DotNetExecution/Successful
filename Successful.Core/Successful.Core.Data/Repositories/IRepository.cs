using Successful.Core.Domain.Entities;

namespace Successful.Core.Data.Repositories
{
    public interface IRepository<out TEntity, in TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        TEntity Get(TPrimaryKey primaryKey);
    }
}
