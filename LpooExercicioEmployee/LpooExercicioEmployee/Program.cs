using LpooExercicioEmployee.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Employees: ");
            int numEmployee = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= numEmployee; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("OutSourced (y/n)?: ");
                char outSourcerd = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

                if (outSourcerd == 'n')
                {
                    Console.WriteLine();
                    employeeList.Add(new Employee(name, hours, valuePerHour));
                    
                }
                else if (outSourcerd == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    Console.WriteLine();
                    employeeList.Add( new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else { Console.WriteLine("You digited invalid option!"); }

            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp.Name+" - $"+emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }






        }
    }
}