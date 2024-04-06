using System;
using System.Text;

namespace SolucaoTarget.Models;

public class InverteCaractere
{
    public string InverteCaracteresPalavra(string palavra)
    {
        int tamanhoPalavra = palavra.Length;
        
        var palavraNova = new StringBuilder();

        for (int i = tamanhoPalavra - 1; i >= 0; i--)
        {
            palavraNova.Append(palavra[i]);
        }

        return palavraNova.ToString();
    }
}
