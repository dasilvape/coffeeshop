using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
  public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
  {
  }

  public DbSet<CoffeeInventory> CoffeeInventory { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<CoffeeInventory>()
      .Property(ci => ci.Name)
      .HasMaxLength(100)
      .IsRequired();

    modelBuilder.Entity<CoffeeInventory>()
      .Property(ci => ci.Size)
      .IsRequired();

    modelBuilder.Entity<CoffeeInventory>()
      .Property(ci => ci.Quantity)
      .IsRequired();
    modelBuilder.Entity<CoffeeInventory>()
      .Property(ci => ci.BuyerName)
      .IsRequired();

    modelBuilder.Entity<CoffeeInventory>()
      .Property(ci => ci.Id)
      .ValueGeneratedOnAdd();
  }
}
