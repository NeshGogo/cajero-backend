using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEndCajero.Models;

namespace BackEndCajero.Data
{
    public class BackEndCajeroContext : DbContext
    {
        public BackEndCajeroContext (DbContextOptions<BackEndCajeroContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
