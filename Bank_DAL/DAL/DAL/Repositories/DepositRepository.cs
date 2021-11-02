using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class DepositRepository : GenericRepository<Deposit>, IDeposit
    {
        public DepositRepository(AutoDBContext context) : base(context)
        {

        }
    }
}
