using PizzaHouse.Data;
using PizzaHouse.Models;

namespace PizzaHouse.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;


        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;

        }
        
        public Menu GetMenu()
        {
            return _pizzaRepository.GetMenu();
        }
    }
}
