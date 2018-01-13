using Microsoft.EntityFrameworkCore;
using eSupport.Services.Equipment.API.Model;
using Microsoft.EntityFrameworkCore.Design;

namespace eSupport.Services.Equipment.API.Infrastructure
{
    public class EquipmentContext : DbContext
    {
        public EquipmentContext(DbContextOptions<EquipmentContext> options)
            : base(options)
        {
            
        }

        public DbSet<EquipmentItem> EquipmentItems { get; set; }
        public DbSet<EquipmentBrand> EquipmentBrands { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EquipmentBrandEntityTypeConfiguration());
            builder.ApplyConfiguration(new EquipmentTypeEntityTypeConfiguration());
            builder.ApplyConfiguration(new EquipmentItemEntityTypeConfiguration());
        }
    }


    public class EquipmentContextDesignFactory : IDesignTimeDbContextFactory<EquipmentContext>
    {
        public EquipmentContext CreateDbContext(string[] args)
        {
            var optionsBuilder =  new DbContextOptionsBuilder<EquipmentContext>()
                .UseSqlServer("Server=.;Initial Equipment=eSupport.Services.EquipmentDb;Integrated Security=true");

            return new EquipmentContext(optionsBuilder.Options);
        }
    }
}