using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            // return a list of strings
            // Create list of employees
            List<Employee> employees = new List<Employee>();
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
                // Create new employee instance
                Employee currentEmployee = new Employee(input, "Yang");
                //Add currentEmployee not a string
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void PrintEmployees(List<Employee> employees)
        {
            // print employees list to console
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetFullName());
            }
        }
        static void Main(string[] args)
        {
            // Call method to get employees
            List<Employee> employees = GetEmployees();

            // Call method to print employees
            PrintEmployees(employees);
        }
    }

}