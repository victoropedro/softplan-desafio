using calculajuros.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace calculajuros.Services
{
    public class CalculoJurosService : ICalculoJurosService
    {
        private string _urlTaxaJuros = "http://taxajuros/taxaJuros";
        private const string _urlCodigo = "https://github.com/victoropedro/softplan-desafio";

        public async Task<decimal> ObterCalculoJuros(decimal valorInicial, int meses)
        {
            var taxaJuros = Convert.ToDouble(await ObterTaxaJuros());

            return await Task.FromResult(CalcularJuros(valorInicial, meses, taxaJuros));
        }

        public string ObterCodigo()
        {
            return _urlCodigo;
        }

        public async Task<string> ObterTaxaJuros()
        {
            #if DEBUG
            _urlTaxaJuros = "https://localhost:44310/taxaJuros";
            #endif
            
            string retorno;

            using (HttpClient httpClient = new HttpClient())
            {
                retorno = await httpClient.GetStringAsync(_urlTaxaJuros);
            }

            return retorno.Replace(".", ",");
        }

        public decimal CalcularJuros(decimal valorInicial, int meses, double taxaJuros)
        {
            return (Math.Truncate(100 * (valorInicial * (decimal)Math.Pow((1 + taxaJuros), (double)meses))) / 100);
        }
    }
}