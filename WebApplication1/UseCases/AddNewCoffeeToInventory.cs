namespace WebApplication1.UseCases;

public class AddNewCoffeeToInventory
{
  private readonly CoffeeInventoryRepository _coffeeInventoryRepository;

  public AddNewCoffeeToInventory(CoffeeInventoryRepository coffeeInventoryRepository)
  {
    _coffeeInventoryRepository = coffeeInventoryRepository;
  }

  public async Task ExecuteAsync(CoffeeInventory coffeeInventory)
  {
    await _coffeeInventoryRepository.CreateCoffeeInventoryAsync(coffeeInventory);
  }
}
