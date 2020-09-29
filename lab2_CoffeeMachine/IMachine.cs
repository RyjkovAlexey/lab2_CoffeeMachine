using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace lab2_CoffeeMachine
{
    interface IMachine
    {
        void Preparing(ButDrink drink, ProgressBar bar, Timer timer);
        void PriceCheck(Collection<ButDrink> butDrinks, Balance balance);
        void DispenseDrink(Button butPickDrink, ButDrink selectedDrink, ProgressBar progressBar1, Collection<ButDrink> butDrinks);
    }
}
