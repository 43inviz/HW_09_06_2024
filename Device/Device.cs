using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_Money.Device
{
    internal class Device
    {
        public string Type {  get; set; }
        
        public Device () { }
        public Device (string type) { 
            Type = type;
        }

        public override string ToString ()
        {
            return $"Type: {Type}";
        }

        public virtual void Sound() { }
        public virtual void Desc () { }
        public virtual void Show () { }
    }
}
