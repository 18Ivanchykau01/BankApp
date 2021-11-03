using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repositories
{
    public class GenericRepository<T>: IDisposable, IGenericRepository<T> where T : class
    {
        protected readonly AutoDBContext _context;
        private bool disposedValue;

        public GenericRepository(AutoDBContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add<T>(entity);
            _context.SaveChanges();
        }
        public T Read(int id)
        {
            return _context.Find<T>(id);
        }

        public IQueryable<T> ReadAll()
        {
            return _context.Set<T>();
        }
        public IQueryable<T> ReadAll(Expression<Func<T,bool>> condition)
        {
            return _context.Set<T>().Where(condition);
        }
        public void Update(T Entity)
        {
            _context.Update<T>(Entity);
            _context.SaveChanges();
        }
        public virtual void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~GenericRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
