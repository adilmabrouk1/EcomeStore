﻿using Core.Entities;
using Core.Specification;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGeniricRepository <T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> GetEntityWithSpec(ISpecification<T> spec);

        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

        Task<int> CountAsync(ISpecification<T> spec);
    }
}
