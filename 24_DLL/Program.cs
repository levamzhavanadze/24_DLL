//// See https://aka.ms/new-console-template for more information
using _24_DLL3;

Console.WriteLine("Hello, World!");

Person person = new Person() { Id = 1, Description = "desc", Name = "John" };

Console.WriteLine(person);


CalculatorBasic a = new CalculatorBasic();

Console.WriteLine(a.Sum(1, 2));

Console.WriteLine(a.Mult(1, 2));
Console.WriteLine(a.Divide(1, 2));