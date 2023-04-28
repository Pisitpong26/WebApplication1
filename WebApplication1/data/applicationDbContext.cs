using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.data
{
    public class applicationDbContext:DbContext
    {
        public applicationDbContext(DbContextOptions<applicationDbContext>options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
