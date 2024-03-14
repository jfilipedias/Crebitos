using System.ComponentModel.DataAnnotations.Schema;

namespace Crebitos.Domain;

[Table("transacoes")]
public class Transacao
{
    [Column("id")]
    public int Id;
    [Column("id_consumidor")]
    public int IdConsumidor { get; set; }
    [Column("descricao")]
    public string Descricao { get; set; } = string.Empty;
    [Column("tipo")]
    public string Tipo { get; set; } = string.Empty;
    [Column("valor")]
    public int Valor { get; set; }
    [Column("realizada_em")]
    public DateTime RealizadaEm { get; set; }
}
