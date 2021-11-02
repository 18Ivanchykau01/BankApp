using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces.Opereations
{
    public interface IDelete<T> where T : class
    {
        public void Delete(T Entity);
    }
}
