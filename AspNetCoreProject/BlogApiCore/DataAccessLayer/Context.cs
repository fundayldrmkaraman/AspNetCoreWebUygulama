using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogApiCore.DataAccessLayer
{
    public class Context:DbContext
    {
        public IEnumerable<object> Users;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PSI1QEU;database=CoreBlogApiDb;integrated security = true;");
        }
        public DbSet<Employee> Employees { get; set; }
        public IEnumerable<object> Writers { get; set; }
    }
}
