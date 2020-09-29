using System;
using System.Windows.Forms;

namespace lab2_CoffeeMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Balance balance = new Balance();

        private void butEspresso_Click(object sender, EventArgs e)
        {
            balance.Pay(butEspresso.Price);
            currentBalance.Text = balance.CurrentBalance.ToString();
        }

        private void butBanknote1_Click(object sender, EventArgs e)
        {
            balance.DepositMoney(butBanknote1.Denomination);
            currentBalance.Text = balance.CurrentBalance.ToString();
        }

        private void butBanknote2_Click(object sender, EventArgs e)
        {
            balance.DepositMoney(butBanknote2.Denomination);
            currentBalance.Text = balance.CurrentBalance.ToString();
        }

        private void butBanknote3_Click(object sender, EventArgs e)
        {
            balance.DepositMoney(butBanknote3.Denomination);
            currentBalance.Text = balance.CurrentBalance.ToString();
        }

        private void butBanknote4_Click(object sender, EventArgs e)
        {
            balance.DepositMoney(butBanknote4.Denomination);
            currentBalance.Text = balance.CurrentBalance.ToString();
        }
    }
}
