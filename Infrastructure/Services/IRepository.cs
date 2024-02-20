using Infrastructure.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition, 
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null);
        
        T? GetById(Guid id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Save();
    }
}