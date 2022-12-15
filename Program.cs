using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create list of employees
      List<string> employees =  new List<string>(){"Matt", "Andy", "Bill"};
      //  Add employees with Add method
      employees.Add("Vanessa");
      employees.Add("Lily");
      Console.WriteLine("Please enter a name:");

      // use ReadLine method to assign user input to a variable
      // note: ReadLine causes runtime halt and waits for input
      string input = Console.ReadLine() ?? "";
      employees.Add(input);

      // print employees list to console
      foreach (string employee in employees )
      {
            Console.WriteLine(employee);
      }

    }

  }
}