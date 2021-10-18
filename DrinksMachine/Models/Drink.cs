using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMachine.Models
{
    public class Drink
    {
        public IList<string> Recipe { get; set; }

        public Drink() {
            Recipe = new List<string>();
        }

    }
}
