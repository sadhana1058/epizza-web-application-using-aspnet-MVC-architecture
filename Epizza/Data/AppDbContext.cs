using Microsoft.EntityFrameworkCore;

namespace Epizza.Data
{
    public class AppDbContext:DbContext //Make it official translator
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
    }
}
