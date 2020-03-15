using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kaddis.Framework.Utilities.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext context;
        private DbSet<T> dbSet;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }
        public async Task<T> GetById(object id)
        {
            return dbSet.Find(id);
        }
        public async Task<T> Insert(T obj)
        {
            await dbSet.AddAsync(obj);
            await Save();
            return obj;
        }
        public async Task Delete(object id)
        {
            T entityToDelete = await dbSet.FindAsync(id);
            Delete(entityToDelete);
        }
        public void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }

            dbSet.Remove(entityToDelete);
        }
        public async Task Update(T obj)
        {
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            await Save();
        }
        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        Task IGenericRepository<T>.Delete(object Id)
        {
            throw new NotImplementedException();
        }
    }
}
