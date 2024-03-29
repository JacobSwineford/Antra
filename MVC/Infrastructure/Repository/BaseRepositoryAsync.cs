﻿using Core.Contracts.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        MVCDbContext db;
        public BaseRepositoryAsync(MVCDbContext _context)
        {
            db = _context;
        }
        public virtual async Task<int> DeleteAsync(int id)
        {
            var entity = await db.Set<T>().FindAsync(id);
            if (entity != null)
                db.Set<T>().Remove(entity);
            return await db.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public virtual async Task<int> InsertAsync(T entity)
        {
            db.Set<T>().Add(entity);
            return await db.SaveChangesAsync();
        }

        public virtual async Task<int> UpdateAsync(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            return await db.SaveChangesAsync();
        }

        
    }
}
