using System.Data.Entity;

namespace CounterApplication
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CounterModel> CounterModels { get; set; }
    }
}