using System.Threading.Tasks;
using Xunit;

namespace taxajuros.teste.integracao
{
    public class TaxaJurosServiceTeste
    {
        private readonly IntegracaoServiceTeste _integracaoServiceTeste;

        public TaxaJurosServiceTeste()
        {
            _integracaoServiceTeste = new IntegracaoServiceTeste();
        }

        [Fact]
        public async Task TaxaJurosController_ObterTaxaJuros_Sucesso()
        {
            var response = await _integracaoServiceTeste._client.GetAsync("/taxaJuros");
            response.EnsureSuccessStatusCode();
        }
    }
}