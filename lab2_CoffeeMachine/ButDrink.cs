using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_CoffeeMachine
{
    public partial class ButDrink : UserControl
    {
        private bool isSelected = false;
        public ButDrink()
        {
            InitializeComponent();
        }

        public string DrinkName
        {
            get { return this.button1.Text; }
            set { this.button1.Text = Price>0 ? $"{value}\n{Price}" : value; }
        }

        public void Select()
        {
            isSelected = !isSelected;
            Highlighting();
        }

        private void Highlighting()
        {
            this.button1.BackColor = isSelected ? Color.GreenYellow : default;
        }

        public event EventHandler Click
        {
            add
            {
                button1.Click += value;
            }
            remove
            {
                button1.Click -= value;
            }
        }

        public int Price { get; set; }
    }
}