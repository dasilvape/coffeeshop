using Microsoft.EntityFrameworkCore;

public class CoffeeInventoryRepository
{
  private readonly MyDbContext _dbContext;

  public CoffeeInventoryRepository(MyDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public async Task CreateCoffeeInventoryAsync(CoffeeInventory coffeeInventory)
  {
    _dbContext.CoffeeInventory.Add(coffeeInventory);
    await _dbContext.SaveChangesAsync();
  }

  public async Task<CoffeeInventory> GetCoffeeInventoryByIdAsync(Guid id)
  {
    return await _dbContext.CoffeeInventory.FirstOrDefaultAsync(c => c.Id == id);
  }

  public async Task UpdateCoffeeInventoryAsync(CoffeeInventory coffeeInventory)
  {
    _dbContext.Entry(coffeeInventory).State = EntityState.Modified;
    await _dbContext.SaveChangesAsync();
  }

  public async Task DeleteCoffeeInventoryAsync(CoffeeInventory coffeeInventory)
  {
    _dbContext.CoffeeInventory.Remove(coffeeInventory);
    await _dbContext.SaveChangesAsync();
  }

  public async Task<IEnumerable<CoffeeInventory>> GetCoffeeInventoryAsync()
  {
    return await _dbContext.CoffeeInventory.ToListAsync();
  }
}
