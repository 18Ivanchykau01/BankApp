using DAL.Entities;
using DAL.UnitOfWork;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class PersonalInfoService : IPersonalInfoService
    {
        private readonly IUnitOfWork _uow;
        public PersonalInfoService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public void Create(PersonalInfo user)
        {
            _uow.PersonalInfos.Create(user);
        }

        public void Delete(int id)
        {
            var info = Get(id);
            info.IsDeleted = true;
            Update(info);
        }
        public void Clear(int id)
        {
            _uow.PersonalInfos.Delete(Get(id));
        }

        public PersonalInfo Get(int personId)
        {
            return _uow.PersonalInfos.Read(personId);
        }

        public void Update(PersonalInfo info)
        {

            _uow.PersonalInfos.Update(info);
        }
    }
}
