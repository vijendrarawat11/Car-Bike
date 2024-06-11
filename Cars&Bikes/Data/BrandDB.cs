using Cars_Bikes.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Data
{
    public class BrandDB:DbContext
    {
        public BrandDB(DbContextOptions<BrandDB> options) : base(options)
        {

        }
        public DbSet<TwoWheelerBrand> TwowheelerBrands { get; set; }
        public DbSet<TwoWheeler> Twowheelers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TwoWheelerBrand>().HasKey(t => t.TWBrandId);
            modelBuilder.Entity<TwoWheeler>().HasOne(s => s.TwoWheelerBrands).WithMany(b => b.TwoWheelers).HasForeignKey(s => s.TwoWBrandId).OnDelete(DeleteBehavior.ClientSetNull);
            
        }
    }
}
