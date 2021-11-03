using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces.Opereations
{
    public interface IUpdate<T> where T : class
    {
        public void Update(T Entity);
    }
}
