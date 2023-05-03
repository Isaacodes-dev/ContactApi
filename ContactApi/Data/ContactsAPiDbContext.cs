using ContactApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactApi.Data
{
    public class ContactsAPiDbContext: DbContext 
    {
        public ContactsAPiDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
