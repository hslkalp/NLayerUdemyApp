﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        #region IGenereicRepository Methods
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<T> AddRangeAsync(IEnumerable<T> entities);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        #endregion
    }
}
