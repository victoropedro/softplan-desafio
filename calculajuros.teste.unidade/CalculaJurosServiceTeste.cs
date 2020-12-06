using Xunit;
using calculajuros.Services;
using System;

namespace calculajuros.teste.unidade
{
    public class CalculaJurosServiceTeste
    {
        [Fact]
        public void CalculoJurosController_ObterCalculoJuros_Sucesso()
        {
            taxajuros.Services.TaxaJurosService taxaJurosService = new taxajuros.Services.TaxaJurosService();
            CalculoJurosService calculoJurosService = new CalculoJurosService();

            var taxajuros = Convert.ToDouble(taxaJurosService.ObterTaxaJuros());
            var valorcalculado = calculoJurosService.CalcularJuros(100, 5, Convert.ToDouble(taxajuros));

            Assert.Equal($"105,10", valorcalculado.ToString("#0.00"));
        }
    }
}