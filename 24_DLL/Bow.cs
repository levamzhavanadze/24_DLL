using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_DLL
{
    internal class Bow : Weapon
    {
        public override int Power { get; set; }
        public override int Lethality { get; set; }
        public int Accuracy { get; set; }
        public int ArrowQuantity { get; set; }


        public Bow()
        {
            Power = GenerateProperty();
            Lethality = GenerateProperty();
            Accuracy = GenerateProperty();
            ArrowQuantity = GenerateProperty();
        }


        public override string ToString()
        {
            return base.ToString() + "; " + $"Accuracy = {Accuracy}; ArrowQuantity = {ArrowQuantity}";
        }

    }
}
