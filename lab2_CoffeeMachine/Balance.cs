using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_CoffeeMachine
{
    class Balance
    {
        public Balance()
        {
            this.CurrentBalance = 0;
        }
        //Оплата
        public void Pay(int price)
        {
            if (this.CurrentBalance>=price)
            {
                this.CurrentBalance -= price;
            }
            else
            {
                throw new ArgumentException($"Текущий баланс равен {this.CurrentBalance}р, этого недостаточно для оплаты напитка");
            }
        }
        //Сдача
        public int ReturnMoney()
        {
            int money = this.CurrentBalance;
            this.CurrentBalance = 0;
            return money;
        }
        //Пополнение счета
        public void DepositMoney(int denomenation)
        {
            this.CurrentBalance += denomenation;
        }
        //Текущий баланс
        public int CurrentBalance
        {
            get;
            private set;
        }

    }
}
