using System.ComponentModel.DataAnnotations.Schema;

namespace Crebitos.Domain;

[Table("saldos")]
public class Saldo
{
    [Column("limite")]
    public int Limite { get; set; }
    [Column("total")]
    public int Total { get; set; }
}
