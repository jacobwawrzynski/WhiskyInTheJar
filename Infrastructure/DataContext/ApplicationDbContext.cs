using Infrastructure.Entities;
using Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Whisky> Whiskies { get; set; }
        public DbSet<ResponseLog> ResponseLogs { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=../Data.db");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            model.Entity<Whisky>(entity =>
            {
                entity.Property(e => e.Rating)
                    .HasConversion(x => x.ToString(),
                        x => (OverallRating)Enum.Parse(typeof(OverallRating), x)
                     );
            });
        }
    }
}
