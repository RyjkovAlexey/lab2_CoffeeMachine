using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace lab2_CoffeeMachine
{
    public partial class Form1 : Form
    {
        private readonly Balance balance = new Balance();
        private readonly Machine machine = new Machine();
        private readonly Collection<ButDrink> butDrinks = new Collection<ButDrink>();
        private ButDrink selectedDrink;
        private int sugar;
        private int strengthDrink;

        public Form1()
        {
            InitializeComponent();
            foreach (ButDrink drink in tableDrinkButtons.Controls)
            {
                butDrinks.Add(drink);
                drink.Click += (object sender, EventArgs e) => EventSelectDrink(drink, e);
            }

            machine.PriceCheck(butDrinks, balance);
            foreach (ButBanknote banknote in tableLayoutPanel4.Controls)
            {
                banknote.Click += (object sender, EventArgs e) => EventBanknoteClick(banknote, e);
            }

            sugar = barSugar.Value;
            strengthDrink = barStrength.Value;
            butPickDrink.Enabled = false;
            butCancelingOperation.Enabled = false;
        }


        #region butDrinks

        private void EventSelectDrink(ButDrink drink, EventArgs e)
        {
            balance.Pay(drink.Price);
            currentBalance.Text = balance.CurrentBalance.ToString();
            selectedDrink = drink;
            selectedDrink.Sugar = sugar;
            selectedDrink.Strength = strengthDrink;
            selectedDrink.Select(butDrinks);
            machine.Preparing(selectedDrink, progressBar1, timer1);
            butPickDrink.Enabled = true;
            butCancelingOperation.Enabled = false;
        }

        #endregion

        #region butBanknots

        private void EventBanknoteClick(ButBanknote banknote, EventArgs e)
        {
            balance.DepositMoney(banknote.Denomination);
            currentBalance.Text = balance.CurrentBalance.ToString();
            machine.PriceCheck(butDrinks, balance);
        }

        //private void butBanknote2_Click(object sender, EventArgs e)
        //{
        //    balance.DepositMoney(butBanknote2.Denomination);
        //    currentBalance.Text = balance.CurrentBalance.ToString();
        //    machine.PriceCheck(butDrinks, balance);
        //}

        //private void butBanknote3_Click(object sender, EventArgs e)
        //{
        //    balance.DepositMoney(butBanknote3.Denomination);
        //    currentBalance.Text = balance.CurrentBalance.ToString();
        //    machine.PriceCheck(butDrinks, balance);
        //}

        //private void butBanknote4_Click(object sender, EventArgs e)
        //{
        //    balance.DepositMoney(butBanknote4.Denomination);
        //    currentBalance.Text = balance.CurrentBalance.ToString();
        //    machine.PriceCheck(butDrinks, balance);
        //}

        #endregion

        private void butReturnMoney_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Сдача составляет {balance.ReturnMoney()}р");
            currentBalance.Text = balance.CurrentBalance.ToString();
            machine.PriceCheck(butDrinks, balance);
        }

        private void barSugar_Scroll(object sender, EventArgs e)
        {
            currentSugar.Text = barSugar.Value.ToString();
            sugar = barSugar.Value;
            butCancelingOperation.Enabled = true;
        }

        private void barStrength_Scroll(object sender, EventArgs e)
        {
            currentStrength.Text = barStrength.Value.ToString();
            strengthDrink = barStrength.Value;
            butCancelingOperation.Enabled = true;
        }

        private void butPickDrink_Click(object sender, EventArgs e)
        {
            machine.DispenseDrink(butPickDrink, selectedDrink, progressBar1, butDrinks);
            machine.PriceCheck(butDrinks, balance);
            machine.CancelOperation(barSugar, barStrength, currentSugar, currentStrength, ref sugar, ref strengthDrink);
        }

        private void butCancelingOperation_Click(object sender, EventArgs e)
        {
            machine.CancelOperation(barSugar, barStrength, currentSugar, currentStrength, ref sugar, ref strengthDrink);
            machine.PriceCheck(butDrinks,balance);
            butCancelingOperation.Enabled = false;
        }
    }
}