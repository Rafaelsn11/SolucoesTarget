using SolucaoTarget.Models;
using System;
/* Questão 1 versão código */
int k = 0, s = 0, indice = 13;
    while(k < indice)
    {
        k++;
        s+= k;
    }
    
    Console.WriteLine(s);
// Resposta: A soma é igual a 91
Console.Write("\n");

/*Questão 2 */


var numeroPerteceFibonacci = new PertenceFibonacci();
// Exemplo
int numeroExemploUm = 13, numeroExemploDois = 10;

if(numeroPerteceFibonacci.NumeroPertenceFibonacci(numeroExemploUm))
    Console.WriteLine("Esse número pertence a sequência de Fibonacci");
else
    Console.WriteLine("Esse número não pertence a sequência de Fibonacci");

Console.Write("\n");
if(numeroPerteceFibonacci.NumeroPertenceFibonacci(numeroExemploDois))
    Console.WriteLine("Esse número pertence a sequência de Fibonacci");
else
    Console.WriteLine("Esse número não pertence a sequência de Fibonacci");

Console.Write("\n");


/*Questão 5 */

string palavra = "abacaxi";

var inverteCaracteresPalavra = new InverteCaractere();
string palavraInvertida = inverteCaracteresPalavra.InverteCaracteresPalavra(palavra);
Console.WriteLine($"{palavraInvertida}");