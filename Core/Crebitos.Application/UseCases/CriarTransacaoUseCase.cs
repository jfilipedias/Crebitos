using Crebitos.Domain;

namespace Crebitos.Application;

public class CriarTransacaoUseCase
{
    public void Execute(int idConsumidor, CriarTransacaoRequestDTO criarTransacaoRequestDTO)
    {
        var transacao = new Transacao()
        {
            IdConsumidor = idConsumidor,
            Tipo = criarTransacaoRequestDTO.Tipo,
            Descricao = criarTransacaoRequestDTO.Descricao,
            Valor = criarTransacaoRequestDTO.Valor,
        };

        throw new NotImplementedException();
    }
}
