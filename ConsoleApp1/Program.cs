using System;

namespace ConsoleApp1
{
    class Program
    {        
        static void AlgMatrizes()
        {

            int linhas, colunas;

            Console.WriteLine("Digite as dimensões da MATRIZ: (Linhas X Colunas) ");
            Console.Write("LINHAS  >>>>> ");
            linhas = int.Parse(Console.ReadLine());
            Console.Write("COLUNAS >>>>> ");
            colunas = int.Parse(Console.ReadLine());

            Matriz mat = new Matriz(linhas, colunas);

            for (int x = 0; x < linhas; x++)
            {
                for (int y = 0; y < colunas; y++)
                {
                    Console.Write("[" + x + "][" + y + "] >>> ");
                    mat.AddValor(x, y, double.Parse(Console.ReadLine()));

                }
            }
            Console.WriteLine("   ");
            Console.WriteLine("\n----- EXIBINDO A MATRIZ INFORMADA ---------   ");
            Console.WriteLine("   ");

            for (int x = 0; x < linhas; x++)
            {
                for (int y = 0; y < colunas; y++)
                {

                    Console.Write("  " + mat.MontarMatriz(x, y));

                    if (mat.MontarMatriz(x, y) > -9 && mat.MontarMatriz(x, y) <= 9)
                    {
                        Console.Write("            ");
                    }
                    if (mat.MontarMatriz(x, y) > 9 && mat.MontarMatriz(x, y) <= 99)
                    {
                        Console.Write("           ");
                    }
                    if (mat.MontarMatriz(x, y) > 99 && mat.MontarMatriz(x, y) <= 999)
                    {
                        Console.Write("          ");
                    }
                    if (mat.MontarMatriz(x, y) > 999 && mat.MontarMatriz(x, y) <= 9999)
                    {
                        Console.Write("         ");
                    }

                    if (y == colunas - 1)
                    {
                        Console.Write("\n");
                    }


                }
            }

            Console.ReadLine();

        }

        static void AlgBanco()
        {

            string numeroCC;
            string nomeTitular;
            double saldoInicial;
            string option;

            Console.WriteLine("Informe os dados solicitados: ");
            Console.Write("Informe o número da conta >>>>  ");
            numeroCC = Console.ReadLine();
            Console.Write("Informe o titular da conta >>>>  ");
            nomeTitular = Console.ReadLine();

            Console.Write("Informe se terá depósito incial >>> (S) ou (N)  ");
            if (Console.ReadLine() == "S")
            {
                Console.Write("Informe o valor >>> ");
                saldoInicial = double.Parse(Console.ReadLine());
            }
            else
            {
                saldoInicial = 0;
            }

            Conta conta = new Conta(numeroCC, nomeTitular, saldoInicial);

            Console.WriteLine("Informe a operação: ");
            Console.WriteLine("1 - Saque ");
            Console.WriteLine("2 - Depósito ");
            Console.WriteLine("3 - Consulta de saldo ");
            Console.WriteLine("4 - Extrato ");
            Console.WriteLine("5 - Resumo da conta ");
            Console.WriteLine("6 - Sair ");

            option = Console.ReadLine();

            while (option != "6")
            {
                if (option == "1")
                {
                    Console.WriteLine("Informe o valor do saque >>>> ");
                    conta.AtualizarSaldo(double.Parse(Console.ReadLine()) * -1);
                }
                if (option == "2")
                {
                    Console.WriteLine("Informe o valor do depósito >>>> ");
                    conta.AtualizarSaldo(double.Parse(Console.ReadLine()));
                }
                if (option == "3")
                {
                    Console.WriteLine("Saldo Atualizado >>>> " + conta.SaldoAtualizado);
                }
                if (option == "4")
                {
                    conta.GerarExtrato();
                }

                if (option == "5")
                {
                    Console.WriteLine(conta.toString());
                }
                Console.WriteLine("\n\n\n Informe a operação: ");
                Console.WriteLine("1 - Saque ");
                Console.WriteLine("2 - Depósito ");
                Console.WriteLine("3 - Consulta de saldo ");
                Console.WriteLine("4 - Extrato ");
                Console.WriteLine("5 - Resumo da conta ");
                Console.WriteLine("6 - Sair ");

                option = Console.ReadLine();
            }
        }

        static void AlgForkGame()
        {
            ForkGame game1 = new ForkGame();
            int f = 1;
            String palavraSorteada;
            while (f == 1)
            {
                Console.WriteLine("");
                palavraSorteada = game1.SortearPalavra();
                Console.WriteLine(game1.MostrarCaracteres(palavraSorteada));
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                int x = 5;
                char letra;

                Console.WriteLine("Você tem " + x + " chances!");
                Console.WriteLine("  ");
                while (x > 0)
                {
                    Console.Write("DÊ seu palpite...>>>  ");
                    letra = char.Parse(Console.ReadLine());
                    if (game1.ExisteLetra(palavraSorteada, letra))
                    {
                        Console.WriteLine("CORRETO!!!");
                        Console.WriteLine("  ");
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        x--;
                        Console.WriteLine("ERRROOOUU!!  ");
                        Console.WriteLine("  ");
                        Console.WriteLine("  ");
                        Console.WriteLine("Você tem " + x + " chance(s)!");
                        Console.WriteLine("  ");

                    }

                }

                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("***** GAME OVER *******");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("Digite 1 para continuar!");
                f = int.Parse(Console.ReadLine());
            }
        }

        static void AlgCalcChuckNorris()
        {
            char op, power = '1';
            double x, y;

            Console.WriteLine("CALCULATOR OF THE CHUCK NORRIS");

            while (power.Equals('1'))
            {
                x = double.Parse(Console.ReadLine());
                op = char.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Calculadora.Calcular(x, op, y);
                Console.WriteLine("---");
                Console.WriteLine(Calculadora.resultado);
                Console.WriteLine("DIGITE 1 CONTINUAR");
                power = char.Parse(Console.ReadLine());

            }
        }

        static void AlgProdutos()
        {
            int qtde;

            Produto produto = new Produto();
            produto.nome = Console.ReadLine();
            produto.preco = double.Parse(Console.ReadLine());
            produto.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(produto);

            Console.Write("Digite a quantidade a ser adicionada: ");
            qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qtde);

            Console.WriteLine("Produto atualizado ");
            Console.Write(produto);
        }

        static void Main(string[] args)
        {

            int option;

            Console.WriteLine("Escolha o programa a ser executado: \n1 - Matrizes \n" +
                "\n2 - Banco\n3 - ForkGame\n4 - Calculadora\n5 - Produtos\n6 - Encerra");

            option = int.Parse(Console.ReadLine());

            while (option != 6)
            {
                if (option == 1)
                {
                    AlgMatrizes();
                }
                if (option == 2)
                {
                    AlgBanco();
                }
                if (option == 3)
                {
                    AlgForkGame();
                }
                if (option == 4)
                {
                    AlgCalcChuckNorris();
                }
                if (option == 5)
                {
                    AlgProdutos();
                }
            }

        }

    }
}

