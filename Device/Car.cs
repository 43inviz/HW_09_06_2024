using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_Money.Device
{
    internal class Car:Device
    {
        public string Model { get; set; }
        public string Year { get; set; }

        public Car() { }
        public Car(string type,string model,string year):base(type)
        {
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nModel: {Model}\nYear: {Year}";

        }

        public override void Sound()
        {
            Console.WriteLine("Car cound\n");
        }

        public override void Desc()
        {
            Console.WriteLine($"Model: {Model}\nYear: {Year}");
        }

        public override void Show()
        {
            Console.WriteLine($"Type: {base.Type}");
        }
    }
}
