using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SaleObject> SaleObjects { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<RealEstateAgent> Realtors { get; set; }
    }
}