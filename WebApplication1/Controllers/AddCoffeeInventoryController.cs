namespace WebApplication1.Controllers;

using Microsoft.AspNetCore.Mvc;
using UseCases;

[ApiController]
[Route("[controller]")]
public class AddCoffeeInventoryController : ControllerBase
{
  private readonly AddNewCoffeeToInventory _addNewCoffeeToInventory;

  public AddCoffeeInventoryController(AddNewCoffeeToInventory addNewCoffeeToInventory)
  {
    _addNewCoffeeToInventory = addNewCoffeeToInventory;
  }

  [HttpPost(Name = "AddCoffeeInventory")]
  public async Task<IActionResult> AddCoffeeInventory([FromBody] CoffeeInventory coffeeInventory)
  {
    await _addNewCoffeeToInventory.ExecuteAsync(coffeeInventory);
    return Ok();
  }
}
