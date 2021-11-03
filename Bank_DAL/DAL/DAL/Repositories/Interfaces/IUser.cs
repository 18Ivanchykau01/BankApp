using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace DAL.Repositories.Interfaces
{
    public interface IUser : IGenericRepository<User>
    {
        public void SafeDelete(int id, Audit audit);
    }
}
