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
    public partial class ButBanknote : UserControl
    {
        public ButBanknote()
        {
            InitializeComponent();
        }

        public int Denomination
        {
            get;
            set;
        }

        public string TextBut
        {
            get => this.button1.Text;
            set => button1.Text=Denomination>0?$"{Denomination}р":$"{value}";
        }
    }
}
