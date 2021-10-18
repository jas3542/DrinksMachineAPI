using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMachine.Models
{
    public class Tea : Drink
    {
        public bool LeamonTea { get; set; }

        public Tea() {
            this.LeamonTea = false;
        }

    }
}
