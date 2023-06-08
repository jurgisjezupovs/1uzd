using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
// using System.Tasks;

namespace _1uzd
{
    internal class Program
    {
        delegate double Matematika(double x, double y);
        static double Saskaitit(double x, double y)
        {
            return x + y;
        }
        static double Atnemt(double x, double y)
        {
            return x - y;   
        }
        static double Reizinat(double x, double y)
        {
            return x * y;
        }
        static double Dalit(double x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("woo, I'm on github!");
            System.Console.WriteLine("testing Jenkins!")
            Matematika del = null;
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("Izvēlies darbību!");
                Console.WriteLine("1 - saskaitīt");
                Console.WriteLine("2 - atņemt");
                Console.WriteLine("3 - dalīt");
                Console.WriteLine("4 - reizināt");
                Console.WriteLine("5 - iziet no programmas");
                Console.Write("Jūsu izvēle: ");
                int izvele = Convert.ToInt32(Console.ReadLine());

                switch(izvele)
                {
                    case 1:
                        del += Saskaitit;
                        break;
                    case 2:
                        del += Atnemt;
                        break;
                    case 3:
                        del += Dalit;
                        break;
                    case 4:
                        del += Reizinat;
                        break;
                    case 5:
                        finished = true;
                        continue;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Nepareiza izvēle!");
                        Console.WriteLine();
                        continue;
                }
                if (del != null)
                {
                    Console.Write("Ievadiet skaitli x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ievadiet skaitli y: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    double result = del(x, y);
                    Console.WriteLine();
                    Console.WriteLine($"Rezultāts - {result}");
                    Console.WriteLine();
                }
            }
        }
    }
}
