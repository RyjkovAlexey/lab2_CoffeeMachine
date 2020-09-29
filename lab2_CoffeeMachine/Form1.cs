using System;
using System.Collections.ObjectModel;
using System.Drawing;
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
            foreach (ButDrink control in tableDrinkButtons.Controls)
            {
                butDrinks.Add(control);
                control.Click += (object sender, EventArgs e) => butEspresso_Click(control, e);
            }
            machine.PriceCheck(butDrinks, balance);
            foreach (ButBanknote banknote in tableLayoutPanel4.Controls)
            {
                banknote.Click += (object sender, EventArgs e) => butBanknote1_Click(banknote, e);
            }

            sugar = barSugar.Value;
            strengthDrink = barSugar.Value;
        }


        #region butDrinks

        private void butEspresso_Click(ButDrink drink, EventArgs e)
        {
            balance.Pay(drink.Price);
            currentBalance.Text = balance.CurrentBalance.ToString();
            selectedDrink = drink;
            selectedDrink.Sugar = sugar;
            selectedDrink.Strength = strengthDrink;
            selectedDrink.Select(butDrinks);
            machine.Preparing(selectedDrink, progressBar1,timer1);
        }

        #endregion

        #region butBanknots

        private void butBanknote1_Click(ButBanknote banknote, EventArgs e)
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
        }

        private void barSugar_Scroll(object sender, EventArgs e)
        {
            currentSugar.Text = barSugar.Value.ToString();
            sugar = barSugar.Value;
        }

        private void barStrength_Scroll(object sender, EventArgs e)
        {
            currentStrength.Text = barStrength.Value.ToString();
            strengthDrink = barStrength.Value;
        }
    }
}