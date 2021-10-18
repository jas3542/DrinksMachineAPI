using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMachine.Models
{
    public class Coffee: Drink
    {
        public bool Milk { get; set; }
        public bool Sugar { get; set; }
        
        public Coffee() {
            this.Milk = false;
            this.Sugar = false;
        }

    }
}
