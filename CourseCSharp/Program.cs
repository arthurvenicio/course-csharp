using System.Globalization;
using System.Collections.Generic;
using System;
using CourseCSharp.Entities;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string o = Console.ReadLine();


                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                switch(o)
                {
                    case "y":
                        Console.Write("Additional charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine());
                        Employee e = new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
                        employees.Add(e);
                        break;
                    default:
                        Employee e2 = new Employee(name, hours, valuePerHour);
                        employees.Add(e2);
                        break;
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee e in employees){
                Console.WriteLine(e);
            }
        }
    }
}
