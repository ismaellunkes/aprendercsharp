using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Digite um número (0 encerra): ");
            double x = double.Parse(Console.ReadLine());

            while (x > 0)
            {

                Console.WriteLine("Escolha o calculo desejado: ");
                Console.WriteLine("1 - RAIZ QUADRADA");
                Console.WriteLine("2 - POTENCIAÇÃO");
                Console.WriteLine("3 - DIVISÃO ");
                Console.WriteLine("4 - SOMA");
                Console.WriteLine("5 - MULTIPLICAÇÃO");
                Console.WriteLine("6 - SUBTRAÇÃO");
                Console.WriteLine("T - TODOS");

                char option = char.Parse(Console.ReadLine());

                if (option == 'T' || option == '1')
                {
                    Console.WriteLine("Raiz Quadrada >>> " + Math.Sqrt(x));
                }
                if (option == 'T' || option == '2')
                {
                    Console.WriteLine("Digite a potência: ");
                    Console.WriteLine("Potenciação   >>> " + Math.Pow(float.Parse(Console.ReadLine()), x));
                }
                if (option == 'T' || option == '3')
                {
                    Console.WriteLine("Digite o valor a ser dividido: ");
                    Console.WriteLine("Divisão >>> " + x / float.Parse(Console.ReadLine()));
                }
                if (option == 'T' || option == '4')
                {
                    Console.WriteLine("Digite o valor a ser somado: ");
                    Console.WriteLine("Soma >>> " + (x + float.Parse(Console.ReadLine())));
                }
                if (option == 'T' || option == '5')
                {
                    Console.WriteLine("Digite o valor a ser multiplicado: ");
                    Console.WriteLine("Soma >>> " + (x * float.Parse(Console.ReadLine())));
                }
                if (option == 'T' || option == '6')
                {
                    Console.WriteLine("Digite o valor a ser subtraído: ");
                    Console.WriteLine("Soma >>> " + (x - float.Parse(Console.ReadLine())));
                }

                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("*****");
                Console.WriteLine("     ");                
                Console.WriteLine("Digite um número (0 encerra): ");
                x = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("******  THANK'S BYE BYE   ********");
            Console.Read();

        }
    }
}
