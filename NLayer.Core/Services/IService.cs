﻿using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        #region IService Methods
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
        #endregion
    }
}
