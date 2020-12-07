using System.Threading.Tasks;
using Xunit;

namespace calculajuros.teste.integracao
{
    public class CalculaJurosServiceTeste
    {
        private readonly IntegracaoServiceTeste _integracaoServiceTeste;

        public CalculaJurosServiceTeste()
        {
            _integracaoServiceTeste = new IntegracaoServiceTeste();
        }

        [Fact]
        public async Task CalculoJurosController_ObterCodigo_Sucesso()
        {
            var response = await _integracaoServiceTeste._client.GetAsync("/showmethecode");
            response.EnsureSuccessStatusCode();
        }
    }
}