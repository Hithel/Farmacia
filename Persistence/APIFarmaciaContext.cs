
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
    public class APIFarmaciaContext : DbContext
        {
            public APIFarmaciaContext(DbContextOptions<APIFarmaciaContext> options) : base(options)
            {}
            // public DbSet<> { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }
        }
