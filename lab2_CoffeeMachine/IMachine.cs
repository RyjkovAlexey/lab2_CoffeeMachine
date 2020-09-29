using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_CoffeeMachine
{
    interface IMachine
    {
        void Preparing(ButDrink drink, ProgressBar bar, Timer timer);
        void PriceCheck(Collection<ButDrink> butDrinks, Balance balance);
        void DispenseDrink();
    }
}
