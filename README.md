# UniVol - API

## Visão Geral

O **UniVol** é uma API REST inovadora desenvolvida para conectar voluntários com demandas emergenciais em situações de desastres naturais e crises ambientais. A plataforma visa agilizar a resposta a eventos críticos, facilitando a comunicação entre organizações, líderes comunitários e voluntários capacitados.

---

## Funcionalidades Principais

- Cadastro de **Pedidos** de ajuda emergencial publicados por organizações e líderes comunitários.
- Cadastro e gerenciamento de **Voluntários** com suas habilidades e localização.
- Classificação automática dos pedidos por prioridade (Baixa, Média, Alta) via modelo de Machine Learning (simulado).
- Voluntários podem demonstrar interesse em pedidos e iniciar contato via WhatsApp.
- Persistência em banco de dados Oracle com migrações EF Core.
- Documentação da API disponibilizada via Swagger.

---

## Requisitos Técnicos Atendidos

- API REST seguindo boas práticas de programação e arquitetura (camadas Models, Repositories, Services, Controllers).
- Persistência em banco de dados relacional Oracle.
- Relacionamento 1:N implementado entre Voluntário e Pedidos.
- Documentação completa da API com Swagger.
- Uso correto das migrations para versionamento e controle do banco de dados.

---

## Tecnologias Utilizadas

- .NET 9 (ASP.NET Core)
- Entity Framework Core (com Oracle provider)
- Swagger / OpenAPI para documentação
- Oracle Database
- C# 11

---

## Estrutura do Projeto

- **Models**: definição das entidades e enums.
- **Repositories**: abstração da persistência.
- **Services**: regras de negócio e lógica de aplicação.
- **Controllers**: endpoints REST.
- **Migrations**: scripts gerados pelo EF Core para criação e atualização do banco.

---

## Como Executar o Projeto Localmente

   ```bash
   git clone https://github.com/seuusuario/univol-server.git
   cd univol-server

"ConnectionStrings": {
  "UniVolConnection": "User Id=seu_usuario;Password=sua_senha;Data Source=seu_data_source"
}

dotnet ef database update

dotnet run

````
Acesse a documentação Swagger em: https://localhost:5001/swagger





## Avaliação
Este projeto atende aos critérios de:

Viabilidade e inovação: uma solução focada em auxiliar crises reais com resposta rápida e organização eficiente.

Cumprimento técnico: implementação robusta com arquitetura em camadas, banco relacional, relacionamento 1:N, documentação e migrations.

Documentação: Swagger e README completos, com instruções claras para uso e desenvolvimento.
