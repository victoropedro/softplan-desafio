using Xunit;
using taxajuros.Services;

namespace taxajuros.teste.unidade
{
    public class TaxaJurosServiceTeste
    {
        [Fact]
        public void TaxaJurosController_ObterTaxaJuros_Sucesso()
        {
            TaxaJurosService taxaJurosService = new TaxaJurosService();

            var taxajuros = taxaJurosService.ObterTaxaJuros();

            Assert.Contains($"0,01", taxajuros.ToString());
        }
    }
}