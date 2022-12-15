using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
      static List<string> GetEmployees()
      {
            // return a list of strings
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
            }
            return employees;
      }

      static void PrintEmployees(List<string> employees)
      {
            // print employees list to console
            foreach (string employee in employees )
            {
                  Console.WriteLine(employee);
            }
      }
      static void Main(string[] args)
      {
            // Call method to get employees
            List<string> employees = GetEmployees();
            
            // Call method to print employees
            PrintEmployees(employees);
      }
  }
}