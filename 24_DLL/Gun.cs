using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_DLL
{
    internal class Gun : Weapon
    {
        public override int Power { get; set; }
        public override int Lethality { get; set; }
        public int BulletQuantity { get; set; }
    

        public Gun()
        {
            
                Power = GenerateProperty();
                Lethality = GenerateProperty();
                BulletQuantity = GenerateProperty();
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Bullet Quantity = {BulletQuantity}";
        }
    }
}
