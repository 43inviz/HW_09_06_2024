using HW_09_Money.Device;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_09_Money
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Money + product

            //Money money = new Money();
            //Console.WriteLine(money.ToString());
            //money.addMoney();
            //Console.WriteLine(money.ToString());

            //Product product = new Product(9,5,"Bread");
            //Console.WriteLine(product.ToString());
            //product.removePrice();
            //Console.WriteLine(product.ToString());

            //Car car = new Car("Car","1","234");
            //Console.WriteLine(car);
            //car.Sound();
            //car.Desc();
            //car.Show();

            SteamShip ship = new SteamShip("ship", "20", "SHIP");
            ship.Show();
            ship.Desc();

            





            Console.ReadKey();
        }
    }
}
