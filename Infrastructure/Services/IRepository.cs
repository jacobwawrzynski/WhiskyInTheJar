﻿using Infrastructure.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        // IEnumerable instead of IQueryable due to SQLite local file
        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> condition);
        T? GetById(Guid id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Save();
        // Saving can be commited also in UnitOfWork
    }
}
