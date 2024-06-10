using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_Money.Device
{
    internal class SteamShip:Device
    {
        public string ShipHeight { get; set; }
        public string ShipName { get; set; }

        

        public SteamShip(string type,string shipHeight, string shipName) : base(type)
        {
            ShipHeight = shipHeight;
            ShipName = shipName;
        }

        public override void Sound()
        {
            Console.WriteLine("Steam ship sound\n");

        }

        public override void Desc()
        {
            Console.WriteLine($"Ship height: {ShipHeight}\nShip name: {ShipName}");
        }

        public override void Show()
        {
            Console.WriteLine($"Type: {base.Type}");
        }
    }
}
