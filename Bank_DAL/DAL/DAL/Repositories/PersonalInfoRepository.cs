using DAL.Repositories.Interfaces;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class PersonalInfoRepository : GenericRepository<PersonalInfo>, IPersonalInfo
    {
        public PersonalInfoRepository(AutoDBContext context) : base(context)
        {

        }

    }
}
