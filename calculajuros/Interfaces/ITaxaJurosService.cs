using System.Threading.Tasks;

namespace calculajuros.Interfaces
{
    public interface ITaxaJurosService
    {
        Task<string> ObterTaxaJuros();
    }
}