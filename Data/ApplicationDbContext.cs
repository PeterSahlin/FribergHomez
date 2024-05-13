using FribergHomez.Const;
using FribergHomez.Models;
using Microsoft.AspNetCore.Identity;
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = APIRoles.User,
                    NormalizedName = APIRoles.User.ToUpper(),
                    Id = "02166575-2238-461f-9e4e-aabb61a072a3"
                },
                new IdentityRole
                {
                    Name = APIRoles.Admin,
                    NormalizedName = APIRoles.Admin.ToUpper(),
                    Id = "1b776bea-26d0-43db-afee-a2dd0870e782"
                }
            );
        }
    }
}