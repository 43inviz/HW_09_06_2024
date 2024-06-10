using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_Money
{
    internal class Product:Money
    {
        public string ProductName { get; set; }

        public Product() { }
        public Product(int main,int coins,string Name):base(main,coins) {
            ProductName = Name;
        }

        public void removePrice()
        {
            int mainAmo, coinAmo;

            string main, coin;

            Console.WriteLine("Enter main: ");
            main = Console.ReadLine();
            int.TryParse(main, out mainAmo);

            Console.WriteLine("Enter coin: ");
            coin = Console.ReadLine();
            int.TryParse(coin, out coinAmo);

            this.removeSumFrom(mainAmo, coinAmo);
            
        }
        public override string ToString()
        {
            return $"Product name: {ProductName}\nProduct Cost: {base.ToString()}";
        }
    }
}
