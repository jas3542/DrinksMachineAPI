using DrinksMachine.Models;
using DrinksMachine.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private IDrinksService _drinksService;
        public DrinksController(IDrinksService drinksService) {
            _drinksService = drinksService;
        }

        [HttpGet]
        public Task<IList<string>> getDrinks()
        {
            return Task.FromResult(_drinksService.getDrinksNames());
        }

        [HttpPost]
        [Route("tea/recipe")]
        public Task<IList<string>> getTea([FromBody] Tea tea)
        {
            //TODO:
            // check if tea is null
            // change return type to IActionResult
            return Task.FromResult(_drinksService.getTeaRecipe(tea));
        }

        [HttpPost]
        [Route("coffee/recipe")]
        public Task<IList<string>> getCoffee([FromBody] Coffee coffee)
        {
            //TODO:
            // check if tea is null
            // change return type to IActionResult
            return Task.FromResult(_drinksService.getCoffeeRecipe(coffee));
        }

        [HttpPost]
        [Route("chocolate/recipe")]
        public Task<IList<string>> getChocolate([FromBody] Chocolate chocolate)
        {
            //TODO:
            // check if tea is null
            // change return type to IActionResult
            return Task.FromResult(_drinksService.getChocolateRecipe(chocolate));
        }
    }
}
