using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_CoffeeMachine
{
    class Machine:IMachine
    {
        public void Preparing(ButDrink drink, ProgressBar bar, Timer timer)
        {

        }

        public void PriceCheck(Collection<ButDrink> drinksCollection, Balance balance)
        {
            foreach (ButDrink butDrink in drinksCollection)
            {
                butDrink.Enabled = butDrink.Price <= balance.CurrentBalance;
            }
        }

        public void DispenseDrink()
        {

        }
    }
}
