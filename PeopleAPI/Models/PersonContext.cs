using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace PeopleAPI.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
