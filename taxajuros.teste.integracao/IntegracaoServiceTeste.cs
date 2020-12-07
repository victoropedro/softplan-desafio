using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

namespace taxajuros.teste.integracao
{
    public class IntegracaoServiceTeste
    {
        public HttpClient _client { get; set; }
        private TestServer _server;

        public IntegracaoServiceTeste()
        {
            CreateServer();
        }

        private void CreateServer()
        {            
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _server.BaseAddress = new Uri("https://localhost:44310");

            _client = _server.CreateClient();
        }
    }
}