using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_Money.Device
{
    internal class Microwave:Device
    {
        public string MicroName { get; set; }
        public Microwave(string type,string name):base(type) { 
            MicroName = name;
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound BIP-BIP\n");
        }

        public override void Show()
        {
            Console.WriteLine($"Type: {base.Type}");
        }

        public override void Desc()
        {
           Console.WriteLine($"Microwave name: {MicroName}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nMicrowave Name: {MicroName}";
        }
    }
}
