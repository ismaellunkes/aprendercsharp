using System;

public class Calculadora
{

    public static double resultado, acumulador;

    public Calculadora()
    {
        acumulador = resultado;
        resultado = 0f;
    }

    public static void Calcular(double a, char operacao, double b)
    {

        if (operacao.Equals('+'))
        {
            Somar(a, b);
        }

        if (operacao.Equals('-'))
        {
            Subtrair(a, b);
        }

        if (operacao.Equals('/'))
        {
            Dividir(a, b);
        }

        if (operacao.Equals('*'))
        {
            Multiplicar(a, b);
        }

    }

    public static void Somar(double a, double b)
    {
        resultado = a + b;
    }

    public static void Subtrair(double a, double b)
    {
        resultado = a - b;
    }

    public static void Dividir(double a, double b)
    {
        resultado = a / b;
    }

    public static void Multiplicar(double a, double b)
    {
        resultado = a * b;
    }

}
