using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext (DbContextOptions<DemoContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(GetType()));
        }

        public DbSet<Pajera> Pajera { get; set; }
        public DbSet<SubPajera> SubPajera { get; set; }
        public DbSet<Inspeccion> Inspeccion { get; set; }
        public DbSet<Adjunto> Adjunto { get; set; }
    }
}
