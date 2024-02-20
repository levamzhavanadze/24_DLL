using System;
using System.Numerics;
using _24_DLL;

//Bow bow = new Bow();

//Console.WriteLine(bow);


//Dagger dagger = new Dagger();

//Console.WriteLine(dagger);

//Gun gun = new Gun();
//Console.WriteLine(gun);



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

var topPower = from p in weapons
                   //where p.Power.CompareTo(weapons[0].Power) == 0
               orderby p.Power descending

               select p;

var result = from s in weapons
             where s.Power == topPower.First().Power
             select s;


foreach(var item in result)
{
    Console.WriteLine(item);
}



