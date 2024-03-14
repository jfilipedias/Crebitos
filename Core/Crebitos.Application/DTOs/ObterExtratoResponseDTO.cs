using System.Text.Json.Serialization;

namespace Crebitos.Application;

public class SaldoObterExtratoResponseDTO
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("limite")]
    public int Limite { get; set; }

    [JsonPropertyName("realizada_em")]
    public DateTime RealizadaEm { get; set; }
}

public class TransacaoObterExtratoResponseDTO
{
    [JsonPropertyName("valor")]
    public int Valor { get; set; }

    [JsonPropertyName("tipo")]
    public string Tipo { get; set; } = string.Empty;

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; } = string.Empty;

    [JsonPropertyName("realizada_em")]
    public DateTime RealizadaEm { get; set; }
}

public class ObterExtratoResponseDTO
{
    [JsonPropertyName("saldo")]
    public SaldoObterExtratoResponseDTO Saldo { get; set; }
    [JsonPropertyName("ultimas_transacoes")]
    public List<TransacaoObterExtratoResponseDTO> UltimasTransacoes { get; set; }
}
