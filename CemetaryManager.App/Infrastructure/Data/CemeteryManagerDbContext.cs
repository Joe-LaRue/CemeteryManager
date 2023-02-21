using CemetaryManager.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CemetaryManager.App.Infrastructure.Data
{
    public class namespace CemetaryManager.App.DbContext : DbContext
    {
        public DbSet<Lot> Lots { get; set; }
        public DbSet<LotOwner> LotOwners { get; set; }
        public DbSet<LotPurchase> LotPurchases { get; set; }

        public namespace CemetaryManager.App.DbContext(DbContextOptions<namespace CemetaryManager.App.DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(namespace CemetaryManager.App.DbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
