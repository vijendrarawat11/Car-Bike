using Cars_Bikes.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Data
{
    public class FourWheelerBrandDB:DbContext
    {
        public FourWheelerBrandDB(DbContextOptions<FourWheelerBrandDB> options) : base(options)
        {
           
        }
        public DbSet<FourWheelerBrand> FourWheelerBrands { get; set; }
    }
}
