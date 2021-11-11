using System;
using System.Globalization;
using System.Collections.Generic;
using _10exercResolvido.Entities;


namespace _10exercResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced? (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hours R$: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional Charge R$: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee (name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }

        }
    }
}
