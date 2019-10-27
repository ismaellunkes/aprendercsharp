using System;

public class Matriz
{
    double[,] mat;
    public Matriz()
    {        
    }
    public Matriz(int lin, int col)
    {
        mat = new double[lin, col];

    }

    public void AddValor(int lin, int col, double valor)
    {
        if (mat != null)
        {
            mat[lin, col] = valor;
        }
    }

    public void RemoveValor(int lin, int col, double valor)
    {
        if (mat != null)
        {
            mat[lin, col] = 0f;
        }
    }
    
    public double MontarMatriz(int lin, int col)
    {
        if (mat != null)
        {
            return mat[lin, col];
        }
        else
        {
            Console.WriteLine("MATRIZ NÃO DEFINIDA!!!");
            return 0;
        }

    }

    /// Achar os valores da diagonal 1,1 2,2 3,3
    /// Achar os valores vizinhos de determinado valor
    /// 

}
