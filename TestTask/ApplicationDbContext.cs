using Microsoft.EntityFrameworkCore;
using TestTask.Entities;

namespace TestTask
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
