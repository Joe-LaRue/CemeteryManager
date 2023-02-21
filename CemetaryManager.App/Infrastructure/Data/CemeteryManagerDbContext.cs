using CemeteryManager.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CemeteryManager.App.Infrastructure.Data
{
    public class namespace CemeteryManager.App.DbContext : DbContext
    {
        public DbSet<Lot> Lots { get; set; }
        public DbSet<LotOwner> LotOwners { get; set; }
        public DbSet<LotPurchase> LotPurchases { get; set; }

        public namespace CemeteryManager.App.DbContext(DbContextOptions<namespace CemeteryManager.App.DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(namespace CemeteryManager.App.DbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
