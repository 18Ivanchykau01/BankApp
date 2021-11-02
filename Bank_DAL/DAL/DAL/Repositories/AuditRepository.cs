using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class AuditRepository : GenericRepository<Audit>, IAudit
    {
        public AuditRepository(AutoDBContext context) : base(context)
        {
            
        }

    }
}
