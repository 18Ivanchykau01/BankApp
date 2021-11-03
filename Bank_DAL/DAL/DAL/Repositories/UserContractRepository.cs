using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class UserContractRepository : GenericRepository<UserContract>, IUserContract
    {
        public UserContractRepository(AutoDBContext context) : base(context)
        {

        }

    }
}
