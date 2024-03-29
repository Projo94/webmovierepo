﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Movies.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);

        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task SaveChangesAsync();
        Task<IReadOnlyList<T>> GetPagedResponseAsync(int page, int size);
        Task AddRange(List<T> entityList);


    }
}
