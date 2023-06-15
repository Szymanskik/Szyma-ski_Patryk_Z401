using Microsoft.EntityFrameworkCore;
using SystemZarzadzaniaPracownikami.Models;

namespace SystemZarzadzaniaPracownikami
{
    
    public class DbUserContext:DbContext
    {
        public DbUserContext(DbContextOptions<DbUserContext> options) : base(options) {}
        
        
        public DbSet<User>Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
