using System.Threading.Tasks;
using taxajuros.Interfaces;

namespace taxajuros.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public double ObterTaxaJuros()
        {
            return 0.01;
        }
    }
}