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

            model.Entity<Whisky>(entity =>
            {
                entity.Property(e => e.Rating)
                    .HasMaxLength(9)
                    .HasConversion(x => x.ToString(),
                    x => (OverallRating)Enum.Parse(typeof(OverallRating), x));
            });

            model.Entity<Product>(entity =>
            {
                entity.Property(e => e.HealthRating)
                    .HasMaxLength(7)
                    .HasConversion(x => x.ToString(),
                    x => (HealthRating)Enum.Parse(typeof(HealthRating), x));

                entity.Property(e => e.FoodCategory)
                    .HasMaxLength(20)
                    .HasConversion(x => x.ToString(),
                    x => (FoodCategory)Enum.Parse(typeof(FoodCategory), x));
            });

            model.Entity<Meal>(entity =>
            {
                entity.Property(e => e.HealthRating)
                    .HasMaxLength(7)
                    .HasConversion(x => x.ToString(),
                    x => (HealthRating)Enum.Parse(typeof(HealthRating), x));

                entity.Property(e => e.Rating)
                    .HasMaxLength(9)
                    .HasConversion(x => x.ToString(),
                    x => (OverallRating)Enum.Parse(typeof(OverallRating), x));
            });

            model.Entity<NutritionFacts>()
                .HasOne(nf => nf.Product)
                .WithOne(i => i.NutritionFacts)
                .HasForeignKey<NutritionFacts>(nf => nf.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
