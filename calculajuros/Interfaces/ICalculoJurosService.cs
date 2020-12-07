using System.Threading.Tasks;

namespace calculajuros.Interfaces
{
    public interface ICalculoJurosService
    {
        Task<decimal> ObterCalculoJuros(decimal valorInicial, int meses);
        string ObterCodigo();
    }
}