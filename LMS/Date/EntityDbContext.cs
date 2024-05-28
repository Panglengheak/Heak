using Microsoft.EntityFrameworkCore;
using LMS.Models;

namespace LMS.Data
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options) 
        { }
        public DbSet<Librarian> Librarians { get; set; }
    }
}
