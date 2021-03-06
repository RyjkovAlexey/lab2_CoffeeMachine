﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            get => this.button1.Text;
            set => this.button1.Text = Price>0 ? $"{value}\n{Price}" : value;
        }

        public void Select(Collection<ButDrink> butDrinks)
        {
            this.isSelected = !this.isSelected;
            this.button1.BackColor = this.isSelected ? Color.GreenYellow : Button.DefaultBackColor;
            foreach (ButDrink butDrink in butDrinks)
            {
                butDrink.Enabled = false;
            }
        }

        public void RecoverBut(Collection<ButDrink> butDrinks)
        {
            this.isSelected = !this.isSelected;
            this.button1.BackColor = this.isSelected ? Color.GreenYellow : Button.DefaultBackColor;
            foreach (ButDrink butDrink in butDrinks)
            {
                butDrink.Enabled = true;
            }
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
        public int CookingTime{ get; set; }
        public int Strength { get; set; }
        public int Sugar { get; set; }
    }
}