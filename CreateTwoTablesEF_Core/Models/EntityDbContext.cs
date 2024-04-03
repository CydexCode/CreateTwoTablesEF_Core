using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CreateTwoTablesEF_Core.Models
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options)
        {
        }

        public DbSet<Entity01> Entity01 { get; set; }
        public DbSet<Entity02> Entity02 { get; set; }
    }
}
