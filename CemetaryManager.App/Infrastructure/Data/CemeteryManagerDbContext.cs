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
    public class CemeteryManagerAppDbContext : DbContext
    {
        public DbSet<Lot> Lots { get; set; }
        public DbSet<LotOwner> LotOwners { get; set; }
        public DbSet<LotPurchase> LotPurchases { get; set; }

        public CemeteryManagerAppDbContext(DbContextOptions<CemeteryManagerAppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CemeteryManagerAppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
