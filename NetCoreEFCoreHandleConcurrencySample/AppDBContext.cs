using Microsoft.EntityFrameworkCore;
using NetCoreEFCoreHandleConcurrencySample.Models;

namespace NetCoreEFCoreHandleConcurrencySample
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // [entity framework - How can I hint the C# 8.0 nullable reference system that a property is initalized using reflection - Stack Overflow](https://stackoverflow.com/questions/57342964/how-can-i-hint-the-c-sharp-8-0-nullable-reference-system-that-a-property-is-init/66955822#66955822)
        public DbSet<Student> Students => Set<Student>();

    }
}
