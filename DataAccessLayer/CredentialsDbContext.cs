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

        public DbSet<UserCredential> UserCredentials { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
