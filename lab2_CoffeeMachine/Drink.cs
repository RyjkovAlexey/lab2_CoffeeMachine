using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_CoffeeMachine
{
    abstract class Drink
    {
        public string NameDrink { get; set; }
        public int PriceDrink { get; set; }
        public int TimePreparing { get; set; }
    }
}
