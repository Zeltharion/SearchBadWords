using Microsoft.EntityFrameworkCore;

namespace SearchBadWords.Model
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Statistics> Statistics { get; set; }
		public DbSet<TopWords> TopWords { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SearchBadWords.db");
        }
    }
}
