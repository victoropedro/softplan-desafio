using Xunit;
using calculajuros.Services;
using System;

namespace calculajuros.teste.unidade
{
    public class CalculaJurosServiceTeste
    {
        [Fact]
        public async void CalculoJurosController_ObterCalculoJuros_Sucesso()
        {
            CalculoJurosService calculoJurosService = new CalculoJurosService();

            var valorcalculado = await calculoJurosService.ObterCalculoJuros(100, 5);

            Assert.Equal($"105,10", valorcalculado.ToString("#0.00"));
        }

        [Fact]
        public void CalculoJurosController_ObterCodigo_Sucesso()
        {
            CalculoJurosService calculoJurosService = new CalculoJurosService();

            var urlCodigo = calculoJurosService.ObterCodigo();

            Assert.Equal("https://github.com/victoropedro/softplan-desafio", urlCodigo.ToString());
        }
    }
}