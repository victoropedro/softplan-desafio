using System.Threading.Tasks;

namespace calculajuros.Interfaces
{
    public interface ICalculoJurosService
    {
        Task<decimal> ObterCalculoJuros(decimal valorInicial, int meses);
        Task<string> ObterTaxaJuros();
        string ObterCodigo();
    }
}