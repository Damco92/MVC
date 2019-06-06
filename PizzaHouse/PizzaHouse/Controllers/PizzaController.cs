using Microsoft.AspNetCore.Mvc;
using PizzaHouse.Data;

namespace PizzaHouse.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            this.pizzaService = pizzaService;
        }

        public IActionResult Menu(int id)
        {
            var menu = pizzaService.GetMenu();

            return View(menu);
        }
    }
}