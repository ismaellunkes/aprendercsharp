using System;
using System.Collections;
using System.Text;

public class ForkGame
{

    ArrayList palavras;
    string caracteresDescobertos;
    StringBuilder stringBuilder = new StringBuilder();

    public ForkGame()
    {
        palavras = new ArrayList();
        palavras.Add("COMPUTADOR");
        palavras.Add("CAMA");
        palavras.Add("BACIA");
        palavras.Add("ISMAEL");
        palavras.Add("FOLHA");        
    }

    public String SortearPalavra()
    {        
        Random rnd = new Random();
        int x = rnd.Next(0, palavras.Count - 1);
        String palavraSorteada = (String)palavras[x];        
        palavras.RemoveAt(x);        
        return palavraSorteada;
    }

    public String MostrarCaracteres(String palavra)
    {
        int x = 0, y = palavra.Length;
        while (x < y)
        {            
            Console.Write(" # ");
            x++;           
        }
        
        return null;
    }

    public String MostrarCaracteres(String palavra, Char letra)
    {
        int x = 0, y = palavra.Length;
        caracteresDescobertos = "";


        while (x < y)
        {          
            if (x == palavra.IndexOf(letra))
            {
                caracteresDescobertos.Insert(x, letra.ToString());
            }
            else
            {
                caracteresDescobertos.Insert(x, " # ");
            }            
            x++;
        }
        Console.Write(caracteresDescobertos);
        return caracteresDescobertos;
    }

    public bool ExisteLetra(String palavra, char letra)
    {

        if (palavra.IndexOf(letra) == -1)
        {
            return false;
        }
        else 
        {
            MostrarCaracteres(palavra, letra);
            return true;
        }

    }








}
