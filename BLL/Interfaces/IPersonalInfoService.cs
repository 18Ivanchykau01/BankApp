using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IPersonalInfoService
    {
        public PersonalInfo Get(int personId);
        public void Update(PersonalInfo info);
        public void Delete(int id);
        public void Clear(int id);
        public void Create(PersonalInfo user);

    }
}
