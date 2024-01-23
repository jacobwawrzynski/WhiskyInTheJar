using Infrastructure.Entities;
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

        public DbSet<Product> Items { get; set; }
        public DbSet<NutritionFacts> NutritionFacts { get; set; }
        public DbSet<Whisky> Whiskies { get; set; }
        public DbSet<Meal> Meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=../Data.db");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            model.Entity<NutritionFacts>()
                .HasOne(nf => nf.Product)
                .WithOne(i => i.NutritionFacts)
                .HasForeignKey<NutritionFacts>(nf => nf.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
