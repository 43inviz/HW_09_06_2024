using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_Money
{
    internal class Money
    {
        public int MainAmount { get; set; }
        public int CoinAmount { get; set; }
        public Money(){}
        public Money(int main,int coin)
        {
            MainAmount = main;
            CoinAmount = coin;
        }

        public override string ToString()
        {
            return $"Balance: {MainAmount}.{CoinAmount}";
        }


        public virtual void addMoney()
        {
            int mainSum;
            int coinSum;

            string Sum;
            string coins;

            Console.Write("Enter main amount: ");
            Sum = Console.ReadLine();
            int.TryParse(Sum, out mainSum);

            Console.Write("Enter coins amount: ");
            coins = Console.ReadLine();
            int.TryParse(coins, out coinSum);

            MainAmount = mainSum;
            CoinAmount = coinSum;
        }

        

        public void removeSumFrom(int main,int coin)
        {
            MainAmount -= main;
            CoinAmount -= coin;
        }
        
    }
}
