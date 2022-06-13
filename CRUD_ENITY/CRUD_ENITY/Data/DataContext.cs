using Microsoft.EntityFrameworkCore;

namespace CRUD_ENITY.Data
{
    public class DataContext : DbContext
        {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

            public DbSet<User> Users { get; set; }
        }
    
}
