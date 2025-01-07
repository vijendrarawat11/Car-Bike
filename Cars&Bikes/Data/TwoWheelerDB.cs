using Cars_Bikes.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Data
{
    public class TwoWheelerDB:DbContext
    {
        public TwoWheelerDB(DbContextOptions<TwoWheelerDB> options) : base(options)
        {

        }
        public DbSet<TwoWheelerBrand> TwowheelerBrands { get; set; }
        public DbSet<TwoWheeler> Twowheelers { get; set; }
        public DbSet<TWSpec> TWSpec { get; set; }
        public DbSet<TWFeatures> TWFeatures { get; set; }
        public DbSet<TWSafety> TWSafety { get; set; }
        public DbSet<TWEngineAndTransmission> TWEngineAndTransmissions { get; set; }
        public DbSet<TWMileageAndPerformance> TWMileageAndPerformances { get; set; }
        //public DbSet<TWChassisAndSuspension> TWChassisAndSuspensions { get; set; }
        public DbSet<TWDimensionsAndCapacity> TWDimensionsAndCapacities { get; set; }
        public DbSet<TWElectricals> TWElectricals { get; set; }
        public DbSet<TWTyresAndBrakes> TWTyresAndBrakes { get; set; }
        public DbSet<TWMotorAndBattery> TWMotorAndBatteries { get; set; }
        public DbSet<TWUnderpinning> TWUnderpinnings { get; set; }
        public DbSet<TWCharging> TWChargings { get; set; }
        public DbSet<TWLatestNews> TWLatestNews { get; set; }
        public DbSet<UpcomingBike> UpcomingBikes { get; set; }
        public DbSet<TWVarient> TWVarients { get; set; }
        public DbSet<TWImageColorPrice> TWImageColorPrices { get; set; }
        public DbSet<TWOrFWContactUs> TWOrFWContactUs { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }
        public DbSet<ValueForMoney> ValueForMoney { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TwoWheelerBrand>().HasKey(t => t.TWBrandId);
            modelBuilder.Entity<TwoWheeler>().HasOne(s => s.TwoWheelerBrands).WithMany(b => b.TwoWheelers).HasForeignKey(s => s.TwoWBrandId).OnDelete(DeleteBehavior.ClientSetNull);
            
        }
    }
}
