using System;
using System.Collections.Generic;
using AbstractChallenge.Entities;
namespace AbstractChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();

            Console.WriteLine("Enter the number of tax payer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or Company (I/C): ");
                char ch = char.Parse(Console.ReadLine());
                ch.ToString().ToLower();
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anual = double.Parse(Console.ReadLine());
                    Console.Write("Health Expenditures: ");
                    double exp = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anual, exp));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anual = double.Parse(Console.ReadLine());
                    Console.Write("Employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anual, emp));
                    
                }

            }
            double tax = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Payer p in list)
            {
                
                tax += p.CalPayer();
                Console.WriteLine(p);
            }
            Console.WriteLine("TOTAL TAXES: $"+ tax);

        }
    }
}
