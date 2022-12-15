using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create list of employees
      List<string> employees =  new List<string>();
      while (true)
      {
            Console.WriteLine("Please enter a name:");
            // use ReadLine method to assign user input to a variable
            // note: ReadLine causes runtime halt and waits for input

            // note coalescing operator ?? - similar to ternary operator in js
            // operator checks for null value and if null replace with "" (empty string)
            string input = Console.ReadLine() ?? "";
            if (input == "")
            {
                  break;
            }
            employees.Add(input);
            // print employees list to console
            foreach (string employee in employees )
            {
                  Console.WriteLine(employee);
            }
      }

    }

  }
}