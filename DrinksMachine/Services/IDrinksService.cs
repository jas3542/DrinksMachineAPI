using DrinksMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMachine.Services
{
    public interface IDrinksService
    {
        public IList<Drink> getDrinks();
        public IList<string> getDrinksNames();
        public IList<string> getTeaRecipe(Tea tea);
        public IList<string> getCoffeeRecipe(Coffee coffee);
        public IList<string> getChocolateRecipe(Chocolate chocolate);

    }
}
