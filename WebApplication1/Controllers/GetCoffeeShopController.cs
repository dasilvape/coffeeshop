namespace WebApplication1.Controllers;

using Microsoft.AspNetCore.Mvc;
using UseCases;

[ApiController]
[Route("[controller]")]
public class GetCoffeeShopController : ControllerBase
{
  private readonly GetCoffeeInventory _coffeeInventory;

  public GetCoffeeShopController(GetCoffeeInventory coffeeInventory)
  {
    _coffeeInventory = coffeeInventory;
  }

  [HttpGet(Name = "GetCoffeeShop")]
  public async Task<IEnumerable<CoffeeInventory>> GetInventoryAsync()
  {
    return await _coffeeInventory.GetCoffeeInventoryAsync();
  }
}
