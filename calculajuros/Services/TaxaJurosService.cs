using System.Net.Http;
using System.Threading.Tasks;
using calculajuros.Interfaces;

namespace calculajuros.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public async Task<string> ObterTaxaJuros()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync("http://localhost:4444/taxaJuros");              
            }
        }
    }
}