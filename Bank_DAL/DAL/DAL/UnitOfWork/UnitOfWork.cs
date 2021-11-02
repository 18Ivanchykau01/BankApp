using DAL.Entities;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AutoDBContext _context;
        private AuditRepository _audits;
        private BankRepository _banks;
        private CardRepository _cards;
        private ClientRepository _clients;
        private DepositRepository _deposits;
        private PactRepository _pacts;
        private PersonalInfoRepository _personalinfo;
        private ServiceRepository _service;
        private UserRepository _users;
        private UserContractRepository _usercontracts;
        public UnitOfWork(AutoDBContext context)
        {
            _context = context;
        }

        public IGenericRepository<Audit> Audits => _audits ??= new AuditRepository(_context);
        public IGenericRepository<Bank> Banks =>_banks ??= new BankRepository(_context);
        public IGenericRepository<Card> Cards => _cards ??= new CardRepository(_context);
        public IGenericRepository<Client> Clients => _clients ??= new ClientRepository(_context);
        public IGenericRepository<Deposit> Deposits => _deposits ??= new DepositRepository(_context);
        public IGenericRepository<Pact> Pacts => _pacts ??= new PactRepository(_context);
        public IGenericRepository<PersonalInfo> PersonalInfos => _personalinfo ??= new PersonalInfoRepository(_context);
        public IGenericRepository<Service> Services => _service ??= new ServiceRepository(_context);
        public IUser Users => _users ??= new UserRepository(_context);
        public IGenericRepository<UserContract> UserContracts => _usercontracts ??= new UserContractRepository(_context);
        void IUnitOfWork.SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
