using Microsoft.EntityFrameworkCore;

namespace MinimalBookApiEF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-DKBREF3Q\\SQLEXPRESS;Database=minimalbookdb;Trusted_Connection=true;Encrypt=false;");

        }

        public DbSet<Book> Books => Set<Book>();


    }
}
