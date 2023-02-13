using Microsoft.EntityFrameworkCore;
using WebAppy1.Model;

namespace WebAppy1.Data
{
    public class AppyDBcontext : DbContext
{
        public AppyDBcontext(DbContextOptions<AppyDBcontext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
}
}
