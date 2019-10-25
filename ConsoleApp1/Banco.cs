using System;
using System.Collections;

public class Conta
{

    public string NumConta { get; }
    public string NomeTitular { get; set; }
    public double SaldoInicial { get; }
    public double SaldoAtualizado { get; set; }
    public double Taxa { get; private set; }

    private ArrayList movimentos;
   

    public Conta(string numConta, string nomeTitular, double saldoInicial)
    {
        this.NumConta = numConta;
        this.NomeTitular = nomeTitular;
        this.SaldoInicial = saldoInicial;
        this.SaldoAtualizado = saldoInicial;
        this.Taxa = -5f;
        this.movimentos = new ArrayList();
    }

    public void AtualizarSaldo(double valorMovimento)
    {
        this.SaldoAtualizado += valorMovimento;
        GerarMovimento(valorMovimento);

        if (valorMovimento < 0)
        {
            GerarMovimento(Taxa);
        }

    }

    private void GerarMovimento(double valorMovimento)
    {
        movimentos.Add(valorMovimento);
    }

    public void GerarExtrato()
    {

        Console.WriteLine("\n\n\n*******  Extrato de movimentações *******\n");
        foreach (double valor in movimentos)
        {            
            Console.WriteLine(valor>0? "                 R$ " + valor + " (C)" : "                 R$ " + valor*-1 + " (D)");            
        }
        Console.WriteLine("\n                 SALDO: R$ " + SaldoAtualizado);
        Console.WriteLine("\n*****************************************");

    }

    public string toString()
    {
        return "CONTA: "+this.NumConta+"\nTITULAR: " + this.NomeTitular+
            "\nSALDO INICIAL: " + this.SaldoInicial+"\nSALDO ATUAL: " + this.SaldoAtualizado;        
    }    

}

