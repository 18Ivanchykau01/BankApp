using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repositories.Interfaces.Opereations
{
    public interface IReadAll<T> where T : class
    {
        public IQueryable<T> ReadAll();
        public IQueryable<T> ReadAll(Expression<Func<T, bool>> condition);
    }
}
