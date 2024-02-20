using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24_DLL
{
    abstract class Weapon
    {
        public abstract int Power { get; set; }
        public abstract int Lethality { get; set; }


        //public Weapon()
        //{
        //    Power = GenerateProperty();
        //    Lethality = GenerateProperty();
        //}


        public virtual int GenerateProperty()
        {
            Random propertyRandomizer = new Random();
            return propertyRandomizer.Next(1, 10);
        }

        public override string ToString()
        {
            return $"Weapon with Power = {Power}; Lethality = {Lethality}";

        }

    }
}
