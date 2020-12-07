# softplan-desafio

TaxaJuros desenvolvida em ASP.NET Core 3.1:
- Endpoint /taxaJuros: Retornar a taxa de juros.

CalculaJuros desenvolvida em ASP.NET Core 3.1 integrada com a api de TaxaJuros com duas funcionalidades:
- Endpoint /showmethecode: Retornar a URL do repositório da aplicação no GitHub.

- Endpoint /calculajuros: Retornar o resultado de juros aplicados ao valor inicial e a quantidade de meses, com taxa de juros retornada da api TaxaJuros

Comandos executar a imagem:
   - git clone https://github.com/victoropedro/softplan-desafio
   - cd softplan-desafio
   - docker-compose build
   - docker-compose up
   
 - TaxaJuros: http://localhost:4444/
 - CalculaJuros: http://localhost:5555/

# Victor de Oliveira Pedro
- https://www.linkedin.com/in/victor-de-oliveira-pedro-9658521b/
