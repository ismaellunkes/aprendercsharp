using System;
using System.Collections.Generic;

/* Algoritmo para praticar o uso de conjuntos, implementado pela classe <HashSet>  */

public class Cursos
{

    public HashSet<int> A;
    public HashSet<int> B;
    public HashSet<int> C;

    public Cursos()
    {
        A = new HashSet<int>();
        B = new HashSet<int>();
        C = new HashSet<int>();
    }

    public void AdicionarAlunos(int codigo, int curso)
    {
        if (curso == 0)
        {
            A.Add(codigo);
        }
        if (curso == 1)
        {
            B.Add(codigo);
        }
        if (curso == 2)
        {
            C.Add(codigo);
        }
    }

    public HashSet<int> AlunosContidos(HashSet<int> CursoX, HashSet<int> CursoY)
    {
        if (CursoX.Count < 1 || CursoY.Count < 1)
        {
            Console.WriteLine("\nUm dos cursos não possui alunos cadastrados!");
        }
        CursoX.IntersectWith(CursoY);
        return CursoX;
    }

    public int TotalAlunos()
    {
        A.UnionWith(B);
        A.UnionWith(C);
        return A.Count;
    }

    public void RelatorioAlunos()
    {

        if (A.Count > 0)
        {
            Console.Write("\nCurso 0 >>> ");
            foreach (int item in A)
            {
                Console.Write(item + " ");
            }
        }

        if (B.Count > 0)
        {
            Console.Write("\nCurso 1 >>> ");
            foreach (int item in B)
            {
                Console.Write(item + " ");
            }
        }

        if (C.Count > 0)
        {
            Console.Write("\nCurso 2 >>> ");
            foreach (int item in C)
            {
                Console.Write(item + " ");
            }
        }
    }

}
