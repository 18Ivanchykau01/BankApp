using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        public UserRepository(AutoDBContext context) : base(context)
        {

        }

        public void Delete(int id)
        {
            _context.Users.Remove(_context.Users.Find(id));
        }
        public void SafeDelete(int id, Audit audit)
        {
            _context.Users.Find(id).IsDeleted = true;
            _context.SaveChanges();
            _context.Update(_context.Users.Find(id));
            audit.UserId = id;
            _context.Add<Audit>(audit);
            _context.SaveChanges();
        }
        
    }
}
