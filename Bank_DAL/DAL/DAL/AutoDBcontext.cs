using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DAL
{
    public class AutoDBContext : DbContext
    { 
    
        public DbSet<User> Users { get; set; }
        public DbSet<UserContract> UserContracts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Pact> Pacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<PersonalInfo> Personal_Infos { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<Card> Cards { get; set; }
        
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3C50V0N\\SQLEXPRESS;DataBase=BANK;Trusted_Connection=True;");
        }
        */
        //public AutoDBContext()
        //{
        //    Database.EnsureDeleted();
        //    Database.EnsureCreated();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // getting connection string from appsetting.jsonDA
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // setting alternate keys
            modelBuilder.Entity<User>().HasAlternateKey(u => u.Login);
            modelBuilder.Entity<Pact>().HasAlternateKey(p => new { p.OpenDate, p.UserId });
            modelBuilder.Entity<Client>().HasAlternateKey(cl => cl.Login);
            // setting indexes
            modelBuilder.Entity<Client>().HasIndex(cl => cl.Login);
            modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();
            modelBuilder.Entity<Audit>().HasIndex(a => a.DeletedDate).HasFilter("[DeletedDate] IS NOT NULL");
            modelBuilder.Entity<Pact>().HasIndex(p => new { p.UserId, p.OpenDate});
            modelBuilder.Entity<UserContract>().HasIndex(UC => UC.UserEmployeeId);
            modelBuilder.Entity<Deposit>().HasIndex(dep => new { dep.UserContractId, dep.PactId});
            modelBuilder.Entity<PersonalInfo>().HasIndex(pr => new { pr.LastName, pr.MiddleName, pr.FirstName });
           
        }
    }

}
