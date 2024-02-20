using System;
using System.Numerics;
using _24_DLL;


List<Weapon> weapons = new List<Weapon>()
{
    new Gun(),
    new Dagger(),
    new Bow(),
};


Console.WriteLine("---All Weapons---");

foreach (Weapon weapon in weapons)
{
    Console.WriteLine(weapon);
}


Console.WriteLine("---Top Powered Weapon---");

//Selects top power form list
var topPower = from p in weapons
                   //where p.Power.CompareTo(weapons[0].Power) == 0
               orderby p.Power descending

               select p;

//filter list and store in variable to print.
var result = from s in weapons
             where s.Power == topPower.First().Power
             select s;

//Print top powered weapons
foreach(var item in result)
{
    Console.WriteLine(item);
}



