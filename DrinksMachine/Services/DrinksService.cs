using DrinksMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMachine.Services
{
    public class DrinksService :  IDrinksService
    {
        private IList<Drink> _listOfDrinks;
        private IList<string> _listOfDrinksNames;
        public DrinksService()
        {
            _listOfDrinks = new List<Drink>();

            _listOfDrinksNames = new List<string> { "Lemon Tea", "Coffee", "Chocolate" };
        }

        public IList<Drink> getDrinks()
        {
            return _listOfDrinks;
        }

        public IList<string> getDrinksNames()
        {
            return _listOfDrinksNames;
        }

        public IList<string> getTeaRecipe(Tea tea)
        {
            var recipe = new List<string>();
            recipe.Add(boilWater());
            recipe.Add("Steeping the water");
            recipe.Add(pourDrinkInCup(tea));
            if (tea.LemonTea)
                recipe.Add("Adding a piece of lemon");

            return recipe;
        }
        public IList<string> getCoffeeRecipe(Coffee coffee)
        {
            var recipe = new List<string>();
            recipe.Add(boilWater());
            recipe.Add("Breawing coffee grounds");
            recipe.Add(pourDrinkInCup(coffee));
            if (coffee.Sugar)
                recipe.Add("Adding Sugar");
           
            return recipe;
        }
        public IList<string> getChocolateRecipe(Chocolate chocolate)
        {
            var recipe = new List<string>();
            recipe.Add(boilWater());
            recipe.Add("Adding chocolate powder");
            recipe.Add(pourDrinkInCup(chocolate));

            return recipe;
        }

        private string boilWater()
        {
            return "Water is boiling";
        }

        /// <summary>
        /// Pouring drink in the cup.
        /// </summary>
        /// <param name="drink">Drink to pour in the cup</param>
        /// <returns>Right string depending on the param</returns>
        private string pourDrinkInCup(Drink drink)
        {
            if (drink is Coffee)
            {
                var wantMilk = ((Coffee)drink).Milk;
                if (wantMilk)
                {
                    return $"Pouring coffee and adding milk";
                }else
                {
                    return $"Pouring coffee";
                }

            }else if (drink is Tea)
            {
                return $"Pouring Tea";

            }else if (drink is Chocolate)
            {
                return $"Pouring Chocolate";

            }
            return "";
            
        }
    }
}
