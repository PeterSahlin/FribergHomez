using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FribergHomez.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
 
        }
     


    }
}
