using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        #region Generic
        public User Get(int id)
        {
            return _uow.Users.Read(id);
        }
        public void Create(User user)
        {
            _uow.Users.Create(user);
        }
        public void Update(User user)
        {
           _uow.Users.Update(user);
        }
        public List<User> GetAll()
        {
            return _uow.Users.ReadAll().Where(u => u.IsDeleted == false).ToList();
        }
        public IQueryable<User> ReadAll(Expression<Func<User, bool>> condition)
        {
            IQueryable<User> users = _uow.Users.ReadAll(condition);
            return users.Where(u => u.IsDeleted == false);
        }

        public void Delete(int id, Audit audit)
        {
            _uow.Users.SafeDelete(id, audit);
        }
        #endregion

        #region Audit
        public Audit AuditFind(int userId)
        {
            return _uow.Audits.Read(userId);
        }
        public void AuditDelete(int userId)
        {
            _uow.Audits.Delete(_uow.Audits.Read(userId));
            _uow.Users.Delete(_uow.Users.Read(userId));
        }
        public void AuditRestore(int userId)
        {
            var user = _uow.Users.Read(userId);
            user.IsDeleted = false;
            _uow.Users.Update(user);
        }
        #endregion

        #region Profile
        public IQueryable<PersonalInfo> GetProfile(int id)       // getting user information
        {
            if (!Get(id).IsDeleted)
            {
                return _uow.PersonalInfos.ReadAll().Where(pf => pf.UserId == id);
            }
            return null;    
        }
        public void SetProfile(int userId, PersonalInfo profile)           // working both for clients and hired users
        {
            profile.UserId = userId;
            profile.ClientId = null;
            _uow.PersonalInfos.Create(profile);
        }
        #endregion

        #region Pact
        public Pact GetPact(int pactID)
        {
            return _uow.Pacts.Read(pactID);
        }
        public void AddPact(Pact pact)
        {
            _uow.Pacts.Create(pact);
        }
        public IQueryable<Pact> GetAllPacts(int userID)
        {
            return _uow.Pacts.ReadAll().Where(pact => pact.UserId == userID);
        }
        public IQueryable<Pact> GetPacts(int userID, Expression<Func<Pact, bool>> condition)
        {
            if (!Get(userID).IsDeleted)
            {
                return _uow.Pacts.ReadAll(condition);
            }
            return null;
        }
        #endregion

        #region Client
        public void AddClient(Client client)
        {
            _uow.Clients.Create(client);
        }
        public Client GetClient(int pactId)
        {
            return _uow.Clients.Read(GetPact(pactId).Client_Id);
        }
        //public IQueryable<Client> GetClients(int userId, Expression<Func<Client, bool>> condition)
        //{
            
        //}

        public void SetClientInfo(int pactid, PersonalInfo info)
        {
            info.ClientId = pactid;
            info.UserId = null;
            _uow.PersonalInfos.Create(info); 
        }

        public IQueryable<PersonalInfo> GetClientInfos(int pactid)
        {
            return _uow.PersonalInfos.ReadAll().Where(person => person.ClientId == GetPact(pactid).Client_Id && person.UserId == null);
        }

        #endregion
    }
}
