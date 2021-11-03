using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class PactRepository : GenericRepository<Pact>, IPact
    {
        public PactRepository (AutoDBContext context) : base (context)
        {

        }
    }
}
