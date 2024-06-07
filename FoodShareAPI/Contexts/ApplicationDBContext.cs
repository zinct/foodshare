using FoodShareAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

[Table("foods")]
public class ApplicationDBContext : DbContext
{
    public DbSet<Food> Foods { get; set; }

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
    }
}
