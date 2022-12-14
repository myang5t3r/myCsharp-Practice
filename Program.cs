using System;
using System.Collections.Generic;

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

  ///////////////////////// Booleans
        // bool isCold = true;
        // Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
        // Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

        // string stringNum = "2";
        // int intNum = Convert.ToInt32(stringNum); //Int32 designates storage available for variable - 2^32 or 4,294,967,296 values 
        // Console.WriteLine(intNum);
        // Console.WriteLine(intNum.GetType());

  ///////////////////////// Dictionaries 
        // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
        // myScoreBoard.Add("firstInning", 10);
        // myScoreBoard.Add("secondInning", 20);
        // myScoreBoard.Add("thirdInning", 30);
        // myScoreBoard.Add("fourthInning", 40);
        // myScoreBoard.Add("fifthInning", 50);

        // Dictionary<string, int> carCost = new Dictionary<string, int>(){
        //   {"F350", 76000},
        //   {"Tundra", 70000}
        // };
        // Console.WriteLine(carCost["F350"]);

  //////////////////// Arrays 
        // string[] favFoods = new string[3]{"pizza", "pho", "Burrito"};
        // string firstFav = favFoods[0];
        // string secondFav = favFoods[1];
        // string thirdFav = favFoods[2];
        // Console.WriteLine("I like {0}, {1}, and {2}", firstFav, secondFav, thirdFav);

  //////////////////// List
        List<string> employee = new List<string>() {"Adam", "Amy"};      
        employee.Add("Matt");
        employee.Add("Jim");

        Console.WriteLine("First Employee = {0}", employee[0]);

    }
  }
}