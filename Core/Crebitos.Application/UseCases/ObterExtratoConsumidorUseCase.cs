using Crebitos.Domain;

namespace Crebitos.Application;

public class ObterExtratoConsumidorUseCase
{
    public ISaldoRepository _saldoRepository;
    public ITransacaoRepository _transacaoRepository;

    public ObterExtratoConsumidorUseCase(ISaldoRepository saldoRepository, ITransacaoRepository transacaoRepository)
    {
        _saldoRepository = saldoRepository;
        _transacaoRepository = transacaoRepository;
    }

    public ObterExtratoResponseDTO Executar(int idConsumidor)
    {
        var saldo = _saldoRepository.ObterPorConsumidor(idConsumidor);
        var ultimasTransacoes = _transacaoRepository.ListarUltimasTransacoesPorConsumidor(idConsumidor);

        var saldoObterExtratoResponseDTO = new SaldoObterExtratoResponseDTO()
        {
            Limite = saldo.Limite,
            Total = saldo.Total,
            RealizadaEm = DateTime.Now
        };

        var ultimasTransacoesObterExtratoReponseDTO = new List<TransacaoObterExtratoResponseDTO>();
        foreach (var transacao in ultimasTransacoes)
        {
            var transacaoObterExtratoResponseDTO = new TransacaoObterExtratoResponseDTO()
            {
                Valor = transacao.Valor,
                Tipo = transacao.Tipo,
                Descricao = transacao.Descricao,
                RealizadaEm = transacao.RealizadaEm
            };

            ultimasTransacoesObterExtratoReponseDTO.Add(transacaoObterExtratoResponseDTO);
        }

        var obterExtratoResponseDto = new ObterExtratoResponseDTO()
        {
            Saldo = saldoObterExtratoResponseDTO,
            UltimasTransacoes = ultimasTransacoesObterExtratoReponseDTO
        };

        return obterExtratoResponseDto;
    }
}
