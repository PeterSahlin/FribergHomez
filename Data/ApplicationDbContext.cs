using FribergHomez.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    //All
    public class ApplicationDbContext : IdentityDbContext<RealEstateAgent>
    {

        public DbSet<Firm> Firms { get; set; }
        public DbSet<SaleObject> SaleObjects { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<RealEstateAgent> RealEstateAgents { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}