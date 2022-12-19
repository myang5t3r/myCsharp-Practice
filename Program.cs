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
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "")
                {
                    break;
                }
                // assign user input into variable to be passed to Employee class to store user data
                Console.WriteLine("Please enter last name:");
                string lastName = Console.ReadLine() ?? "";
                if (lastName == "")
                {
                    break;
                }
                Console.WriteLine("Please enter user id");
                // must cast into int32, ReadLine() returns only strings
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Please enter photo url:");
                string photoUrl = Console.ReadLine() ?? "";

                // Create new employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                //Add currentEmployee not a string
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void Main(string[] args)
        {
            // Call method to get employees
            List<Employee> employees = GetEmployees();

            // Call method to print employees
            Util.PrintEmployees(employees);
        }
    }

}


// NOTE @ #8