using SolucaoTarget.Models;

Console.WriteLine("Questão 1");

var numeroPerteceFibonacci = new PertenceFibonacci();
// Exemplo
int numeroExemploUm = 13, numeroExemploDois = 10;

if (numeroPerteceFibonacci.NumeroPertenceFibonacci(numeroExemploUm))
    Console.WriteLine("Esse número pertence a sequência de Fibonacci");
else
    Console.WriteLine("Esse número não pertence a sequência de Fibonacci");

Console.Write("\n");
if (numeroPerteceFibonacci.NumeroPertenceFibonacci(numeroExemploDois))
    Console.WriteLine("Esse número pertence a sequência de Fibonacci");
else
    Console.WriteLine("Esse número não pertence a sequência de Fibonacci");

Console.Write("\n\n");

Console.WriteLine("Questão 2");

string palavra = "abacaxi";

var verificacaoDaLetraA = new VericacaoDaLetraA();

bool existeLetraA = verificacaoDaLetraA.ExistenciaDaLetraA(palavra);

if (existeLetraA)
    Console.WriteLine("Sim, existe letra A na string");
else
    Console.WriteLine("Não, não existe letra A na string");

int quantidadeDeVezesLetraA = verificacaoDaLetraA.QuantidadeDeVezesDaLetraANaPalavra(palavra);
Console.WriteLine($"A quantidade de vezes que a letra aparece na string é: {quantidadeDeVezesLetraA}");

Console.Write("\n\n");

Console.WriteLine("Questão 3");

int k = 1, soma = 0, indice = 12;

while (k < indice)
{
    k++;
    soma += k;
}

Console.WriteLine($"A soma é: {soma}");
Console.Write("\n\n");

/*Questão 5 */
