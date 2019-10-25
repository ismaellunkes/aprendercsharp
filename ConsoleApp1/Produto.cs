using System;
using System.Globalization;

public class Produto
{

    public String nome;
    public double preco;
    public int quantidade;

    public Produto()
    {
    }

    public double ValorTotalEmEstoque()
    {
        return quantidade * preco;
    }

    public void AdicionarProduto(int qtde)
    {
        quantidade = quantidade + qtde;
    }

    public void RemoverProduto(int qtde)
    {
        quantidade = quantidade - qtde;
    }

    public override string ToString()
    {
        return 
            "Produto: " + nome
            + ", Preço: $ " + preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", Quantidade: " + quantidade
            +", Valor em Estoque: $ "+ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }

}
