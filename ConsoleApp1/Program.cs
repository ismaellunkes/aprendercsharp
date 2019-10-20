using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Raiz Quadrada >>> "+Math.Sqrt(x));
            Console.WriteLine("Potenciação   >>> "+Math.Pow(x, 2));

            Console.Read();

        }
    }
}
