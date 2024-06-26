using FoodShareAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

[Table("foods")]
public class ApplicationDBContext : DbContext
{
    public DbSet<Food> Foods { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Food>(entity => {
            entity.ToTable("foods");
            entity.Property(property => property.CreatedAt)
                  .HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        builder.Entity<User>(entity => {
            entity.ToTable("users");
            entity.Property(property => property.CreatedAt)
                  .HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        builder.Entity<Transaction>(entity => {
            entity.ToTable("transactions");
            entity.HasOne(e => e.User);
            entity.HasOne(e => e.Food);
            entity.Property(property => property.CreatedAt)
                  .HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }
}
