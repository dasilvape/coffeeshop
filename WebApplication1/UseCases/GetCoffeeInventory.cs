namespace WebApplication1.UseCases;

public class GetCoffeeInventory
{
  private readonly CoffeeInventoryRepository _coffeeInventoryRepository;

  public GetCoffeeInventory(CoffeeInventoryRepository coffeeInventoryRepository)
  {
    _coffeeInventoryRepository = coffeeInventoryRepository;
  }

  public async Task<IEnumerable<CoffeeInventory>> GetCoffeeInventoryAsync()
  {
    return await _coffeeInventoryRepository.GetCoffeeInventoryAsync();
  }
}
