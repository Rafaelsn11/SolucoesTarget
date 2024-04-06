using System;
namespace SolucaoTarget.Models;

public class PertenceFibonacci
{
    public bool NumeroPertenceFibonacci(int numero)
    {
        int primeiroTermo = 0, segundoTermo = 1, termoTemporario = 0;
        while(termoTemporario < numero)
        {
            primeiroTermo = segundoTermo;
            segundoTermo = termoTemporario;
            Console.WriteLine($"{termoTemporario} ");
            termoTemporario = primeiroTermo + segundoTermo;
        }
        if(termoTemporario == numero)
            return true;
        
        return false;
    }
}
