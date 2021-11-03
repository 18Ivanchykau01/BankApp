using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces.Opereations
{
    public interface ICreate<T> where T : class
    {
        public void Create(T entity);
    }
}
