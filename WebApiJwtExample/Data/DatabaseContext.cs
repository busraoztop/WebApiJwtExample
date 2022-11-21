using Microsoft.EntityFrameworkCore;
using WebApiJwtExample.Model;

namespace WebApiJwtExample.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DatabaseContext()
        {
        }

        DbSet<User> Users { get; set; }


     
    }
}
