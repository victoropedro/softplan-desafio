using calculajuros.Interfaces;
using System;
using System.Threading.Tasks;

namespace calculajuros.Services
{
    public class CalculoJurosService : ICalculoJurosService
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public CalculoJurosService(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        public CalculoJurosService(){ }

        public async Task<decimal> ObterCalculoJuros(decimal valorInicial, int meses)
        {
            var taxaJuros  = Convert.ToDouble( _taxaJurosService.ObterTaxaJuros());
            return await Task.FromResult(CalcularJuros(valorInicial, meses, taxaJuros));
        }

        public decimal CalcularJuros(decimal valorInicial, int meses, double taxaJuros)
        {
            return (Math.Truncate(100 * (valorInicial * (decimal)Math.Pow((1 + taxaJuros), (double)meses))) / 100);
        }
    }
}