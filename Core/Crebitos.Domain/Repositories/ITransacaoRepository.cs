namespace Crebitos.Domain;

public interface ITransacaoRepository
{
    List<Transacao> ListarUltimasTransacoesPorConsumidor(int idConsumidor);
}
