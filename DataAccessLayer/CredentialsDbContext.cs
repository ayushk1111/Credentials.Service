using Credentials.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credentials.Service.DataAccessLayer
{
    public class CredentialsDbContext : DbContext
    {
        public CredentialsDbContext(DbContextOptions<CredentialsDbContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Credentials;Trusted_Connection=false;User ID=GOMEZIA\Ayush Kumar Jha;pwd=mjolnir;ConnectRetryCount=0",
                    options => options.EnableRetryOnFailure());
        }

        public DbSet<UserCredential> UserCredentials { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
