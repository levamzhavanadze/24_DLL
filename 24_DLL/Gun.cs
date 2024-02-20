using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_DLL
{
    internal class Gun : Weapon
    {

        public int BulletQuantity { get; set; }

        public Gun()
        {
            BulletQuantity = GenerateProperty();
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Bullet Quantity = {BulletQuantity}";
        }
    }
}
