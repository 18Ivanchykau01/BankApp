using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class BankRepository : GenericRepository<Bank>, IBank
    {
        public BankRepository(AutoDBContext context) : base(context)
        {

        }

    }
}
