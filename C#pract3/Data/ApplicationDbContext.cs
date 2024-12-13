using cs_prak_3.Models;
using Microsoft.EntityFrameworkCore;

namespace cs_prak_3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villa { get; set; }
    }
}