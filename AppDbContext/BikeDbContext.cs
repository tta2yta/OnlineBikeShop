using Microsoft.EntityFrameworkCore;
using OnlineBikeShop.Models;

namespace OnlineBikeShop.AppDbContext
{
    public class BikeDbContext: DbContext
    {
        public BikeDbContext( DbContextOptions<BikeDbContext> options): base(options)
        {

        }
        public DbSet<Make> Makes { get; set; }
        public DbSet <Model> Models { get; set; }
    }
}
