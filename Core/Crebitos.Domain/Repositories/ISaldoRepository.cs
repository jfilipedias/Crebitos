namespace Crebitos.Domain;

public interface ISaldoRepository
{
    Saldo ObterPorConsumidor(int IdConsumidor);
}
