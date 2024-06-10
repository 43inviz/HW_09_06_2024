using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_Money.Device
{
    internal class Kettle:Device
    {
        public string KettleName {  get; set; }
        public Kettle(string type,string name):base(type)
        {
            KettleName = name;
        }

        public override void Sound()
        {
            Console.WriteLine("Kettle sound\n");
        }

        public override void Desc()
        {
            Console.WriteLine($"Kettle name: {KettleName}");
        }

        public override void Show()
        {
            Console.WriteLine($"Type: {base.Type}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nKettle Name: {KettleName}";
        }
    }
}
