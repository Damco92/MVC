﻿using System;
using System.Collections.Generic;

namespace PizzaHouse.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        private readonly int _price;

        public Pizza(string name, string description, List<Ingredient> ingredients, int price)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            _price = price;
        }

        public int GetPrice(SizeEnum size)
        {
            switch (size)
            {
                case SizeEnum.Small:
                    return _price;
                case SizeEnum.Medium:
                    return (int) Math.Ceiling(_price * 1.2);
                case SizeEnum.Large:
                    return (int)Math.Ceiling(_price * 1.4);
                default:
                    throw new ArgumentException($"We do not have specified price for this size {size.ToString()}");
            }
        }
    }
}
