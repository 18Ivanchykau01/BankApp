using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {   
        IGenericRepository<Audit> Audits { get; }
        IGenericRepository<Bank> Banks { get; }
        IGenericRepository<Card> Cards { get; }
        IGenericRepository<Client> Clients { get; }
        IGenericRepository<Deposit> Deposits { get; }
        IGenericRepository<Pact> Pacts { get; }
        IGenericRepository<PersonalInfo> PersonalInfos { get; }
        IGenericRepository<Service> Services { get; }
        IUser Users { get; }
        IGenericRepository<UserContract> UserContracts { get; }
        void SaveChanges();
    }
}
