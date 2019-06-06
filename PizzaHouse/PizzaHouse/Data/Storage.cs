using PizzaHouse.Models;
using System.Collections.Generic;

namespace PizzaHouse.Data
{
    internal static class Storage
    {
        public static List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza("Margarite","obicna",new List<Ingredient>
            {
                new Ingredient("cheese", new List<string> ()),
                new Ingredient("pecurki", new List<string> ()),
                new Ingredient("ttesto", new List<string> ())
            }, 100),

            new Pizza("Capri","pojacana",new List<Ingredient>
            {
                new Ingredient("cheese", new List<string> ()),
                new Ingredient("pecurki", new List<string> ()),
                new Ingredient("sunka", new List<string> ()),
                new Ingredient("testo", new List<string> ())
            }, 200),

            new Pizza("Fungi","extra limited edition",new List<Ingredient>
            {
                new Ingredient("cheese", new List<string> ()),
                new Ingredient("pecurki", new List<string> ()),
                new Ingredient("ttesto", new List<string> ()),
                new Ingredient("parmezan", new List<string> ()),
                new Ingredient("pursuta", new List<string> ())
            }, 300),

            new Pizza("Fungi","extra limited edition",new List<Ingredient>
            {
                new Ingredient("cheese", new List<string> ()),
                new Ingredient("pecurki", new List<string> ()),
                new Ingredient("ttesto", new List<string> ()),
                new Ingredient("parmezan", new List<string> ()),
                new Ingredient("pursuta", new List<string> ()),
                new Ingredient("pavlaka", new List<string> ())
            }, 400)
        };

        public static Menu RestorantMenu = new Menu("Kaj Fufo", pizzas);
    }
}
