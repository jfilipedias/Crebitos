using System.Text.Json.Serialization;

namespace Crebitos.Application;

public class CriarTransacaoRequestDTO
{
    [JsonPropertyName("descricao")]
    public string Descricao { get; set; } = string.Empty;
    [JsonPropertyName("tipo")]
    public string Tipo { get; set; } = string.Empty;
    [JsonPropertyName("valor")]
    public int Valor { get; set; }
}
