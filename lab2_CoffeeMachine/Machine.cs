using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace lab2_CoffeeMachine
{
    class Machine : IMachine
    {
        public void Preparing(ButDrink drink, ProgressBar bar, Timer timer)
        {
            int timeStep = drink.CookingTime / 10;
            while (bar.Value < 100)
            {
                Thread.Sleep(timeStep);
                bar.PerformStep();
            }
        }

        public void PriceCheck(Collection<ButDrink> drinksCollection, Balance balance)
        {
            foreach (ButDrink butDrink in drinksCollection)
            {
                butDrink.Enabled = butDrink.Price <= balance.CurrentBalance;
            }
        }

        public void DispenseDrink(Button butPickDrink, ButDrink selectedDrink, ProgressBar progressBar1,
            Collection<ButDrink> butDrinks)
        {
            butPickDrink.Enabled = false;
            selectedDrink.RecoverBut(butDrinks);
            MessageBox.Show(
                $"Ваш напиток готов, наслаждайтесь!!!\nКрепкость напитка: {selectedDrink.Strength}\nСахар {selectedDrink.Sugar}");
            progressBar1.Value = 0;
        }

        public void CancelOperation(TrackBar sugarBar, TrackBar strengthBar, Label sugarLabel, Label strengthLabel,
            ref int sugar, ref int strength)
        {
            sugarBar.Value = default;
            strengthBar.Value = 1;
            sugarLabel.Text = "0";
            strengthLabel.Text = "1";
            sugar = 0;
            strength = 0;
        }
    }
}