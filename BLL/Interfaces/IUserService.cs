using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL
{
    public interface IUserService
    {
        #region generic
        public User Get(int id);
        public void Update(User user);
        public void Delete(int id, Audit audit);
        public void Create(User user);
        public List<User> GetAll();
        public IQueryable<User> ReadAll(Expression<Func<User, bool>> condition);
        #endregion

        #region Audit
        public Audit AuditFind(int userId);
        public void AuditRestore(int userId);
        public void AuditDelete(int userId);
        #endregion

        #region Profile
        public void SetProfile(int userId, PersonalInfo profile);
        public IQueryable<PersonalInfo> GetProfile(int id);
        #endregion

        #region Pacts
        public void AddPact(Pact pact);
        public Pact GetPact(int pactID);
        public IQueryable<Pact> GetAllPacts(int userID);
        public IQueryable<Pact> GetPacts(int userID, Expression<Func<Pact,bool>> condition);
        #endregion

        #region Client
        public void AddClient(Client client);
        public Client GetClient(int pactId);
        //public IQueryable<Client> GetClients(int userId, Expression<Func<Client, bool>> condition);
        public void SetClientInfo(int pactid, PersonalInfo info);
        public IQueryable<PersonalInfo> GetClientInfos(int pactid);
        #endregion
    }
}
