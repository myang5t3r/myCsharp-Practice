using System;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        // string greeting = "Hello";
        // greeting = greeting + "World";
        // Console.WriteLine("greeting" + greeting);

        // Console.WriteLine($"greeting: {greeting}"); 
        // Console.WriteLine("greeting: {0}", greeting);

        // How do you find the area of a square? Area = side * side
        // float side = 3.14;

        // float side = 3.14F;
        // float area = side * side;
        // Console.WriteLine("area: {0}", area);

        // Console.WriteLine("area is a {0}", area.GetType());

        // Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
        // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
        // Console.WriteLine(1 + 2 * 3);     // order of operations
        // Console.WriteLine(10 / 3.0);      // int's and doubles
        // Console.WriteLine(10 / 3);        // int's 
        // Console.WriteLine("12" + "3");    // What happens here?

        // int num = 10;
        // num += 100;
        // Console.WriteLine(num);
        // num ++;
        // Console.WriteLine(num);

        bool isCold = true;
        Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
        Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
    }
  }
}