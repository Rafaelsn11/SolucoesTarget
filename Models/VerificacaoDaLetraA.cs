namespace SolucaoTarget.Models;

public class VericacaoDaLetraA
{
    public bool ExistenciaDaLetraA(string palavra)
    {
        return palavra.IndexOf('a', StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public int QuantidadeDeVezesDaLetraANaPalavra(string palavra)
    {
        return palavra.Count(x => x == 'a' || x == 'A');
    }
}
