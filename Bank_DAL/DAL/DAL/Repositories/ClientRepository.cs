using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClient
    {
        public ClientRepository(AutoDBContext context) : base (context)
        {

        }
    }
}
