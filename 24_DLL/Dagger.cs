using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_DLL
{
    internal class Dagger : Weapon
    {
        public override int Power { get; set; }
        public override int Lethality { get; set; }

        //Type 1 = singleDagger. 2 = DualDagger
        public int DaggerType { get; set; }

        public Dagger()
        {

           
            Lethality = GenerateProperty();
            DaggerType = GenerateProperty();

            if (DaggerType == 2) 
            {
            Power = GenerateProperty() * 2;
            }
            else
            {
                Power = GenerateProperty();
            }
        }

        public override int GenerateProperty()
        {
            Random propertyRandomizer = new Random();
            return propertyRandomizer.Next(1, 3);
        }


        public override string ToString()
        {
            string a = "";
            if (DaggerType == 1)
            {
                a = "singleDagger";
            }
            else
            {
                a = "DualDagger";
            }

            return base.ToString() + "; " + $"DaggerType = {a}";
        }


    }
}
