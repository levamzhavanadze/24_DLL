using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_DLL
{
    internal class Bow : Weapon
    {
        public int Accuracy { get; set; }
        public int ArrowQuantity { get; set; }


        public Bow()
        {
            Accuracy = GenerateProperty();
            ArrowQuantity = GenerateProperty();
        }


        public override string ToString()
        {
            return base.ToString() + "; " + $"Accuracy = {Accuracy}; ArrowQuantity = {ArrowQuantity}";
        }

    }
}
