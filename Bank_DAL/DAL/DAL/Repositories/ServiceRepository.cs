using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IService
    {
        public ServiceRepository (AutoDBContext context) : base(context)
        {

        }
    }
}
