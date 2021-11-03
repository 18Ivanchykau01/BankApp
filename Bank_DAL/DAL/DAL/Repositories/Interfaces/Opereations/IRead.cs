using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DAL.Repositories.Interfaces.Opereations
{
    public interface IRead<T> where T : class
    {
        public T Read(int id);
    }
}
