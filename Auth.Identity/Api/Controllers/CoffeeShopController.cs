using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ICoffeeShopService coffeeShopService;


        public CoffeeShopController(ICoffeeShopService coffeeShopService)
        {
            this.coffeeShopService = coffeeShopService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var coffeeShops = await coffeeShopService.List();
            return Ok(coffeeShops);
        }
    }

}
