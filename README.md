### <h1 align=center> SQUADRA <img src="https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Squadra-logo.jpg" alt="Descrição da imagem" width="30"> - Projeto API RestFUL | .NET - C# </h1>

### Desafio: 
Desenvolver um sistema <b>Gerenciador de Produtos</b>. A proposta é criar uma API de produtos seguindo as boas práticas de desenvolvimento utilizando ASP.NET Core.

Abaixo, serão detalhados os passos para a criação dessa API, seguidos do guia de como executá-la.

1. [Criação do Projeto no Visual Studio](#1)
2. [Instalação das dependências](#2)
3. [Organizando os diretórios](#3)
4. [Criando as primeiras classes](#4)
5. [Let's Code](#5)
6. [JWT Token](#6)
7. [Banco de Dados](#7)
8. [Regras de Negócio](#8)
9. [API & JSON DE EXEMPLO](#9)
------------------------------------------
10. [Passo a passo de como executar a API](#10)

- Os códigos podem ser acessados em -> [Teste API](https://github.com/Rodrigolppz/Squadra-API/tree/main/Teste%20API)

- Obs: O nome ficou como Teste API pois quando eu criei o projeto eu não esperava que fosse trabalhar diretamente nele, porém fui seguindo as aulas e quando me dei conta eu já estava fazendo o projeto ali mesmo...

#

<div id='1'/>
  
# 1 - Criar o projeto no Visual Studio.

Nesse primeiro passo é importante criar o projeto da maneira certa, para isso basta ir até o Visual studio que foi instalado `Visual studio -> Create a new project -> ASP.NET Core Web API -> Create`

![Imagem](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Asp.net.jpg)

Com essa instalação o Visual Studio já deixa o nosso ambiente preparado e facilita bastante o trabalho na hora de desenvolvermos a nossa API.

<div id='2'/>

# 2 - Instalação dos pacotes adicionais do Visual Studio

![Pacotes](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Pacotes.jpg)

<div id='3'/>

# 3 - Organizar os diretórios dentro do projeto

Esta é a etapa inicial do projeto, é aqui que damos o primeiro passo em direção à construção da nossa API.

Para realizar o desafio eu organizei o projeto em 3 pastas:


/Controllers 

/Models

/Services

Explicação:

<b>Controllers</b>: São responsáveis por receber as requisições HTTP, interpretá-las e chamar as funções adequadas dos serviços correspondentes. Eles lidam com a entrada e saída da aplicação, mapeando os endpoints da API para as funções apropriadas.

<b>Models</b>: Models são os responsáveis por representar as entidades da API. Aqui é onde definimos as estruturas que representam os dados utilizados na aplicação.

<b>Services</b>: São responsáveis por armazenar todas as regras de negócio. É onde agrupamos todos os métodos que serão chamados pelos controllers.

<div id='4'/>
  
# 4 - Criação das primeiras classes

Nessa etapa é onde começamos a desenvolver os códigos da nossa aplicação. Para isso, precisamos criar algumas classes, segue abaixo a estrutura:

/Controllers

- ProdutoController.cs

/Models

- Produto.cs

- User.cs

/Services

- ProdutoService.cs
  
- UserService.cs


Seguindo a explicação que foi feita acima, nós definimos o começo da estrutura do nosso projeto.

<div id='5'/>
  
# 5 - Let's Code

Agora com a estrutura do nosso projeto feita, vamos começar a por a mão na massa.

Por se tratar de diversos códigos, achei melhor deixar essa parte para ser analisada direto no projeto real

Clique aqui para ser redirecionado para os códigos da aplicação -> [Códigos API](https://github.com/Rodrigolppz/Squadra-API/tree/main/Teste%20API)

<div id='6'/>

# 6 - JWT Token

Após desenvolver a estrutura da API, é essencial aplicar boas práticas e garantir a segurança. Para isso, utilizamos o JWT (JSON Web Token), que é uma ferramenta de autenticação segura.

![Fluxo API](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/JWT%20Token.jpg)

O funcionamento é simples: o cliente realiza uma requisição do tipo POST, a API valida as informações, gera um token e o envia como resposta ao cliente. Com esse token, o cliente passa a ter autorização para realizar as demais requisições de forma segura.

<div id='7'/>

# 7 - Criação do banco de dados

### 7.1
Para criar e integrar o banco de dados no projeto, basta acessar o menu do Visual Studio em `Tools -> Connect to Database.` Nessa janela, selecione a opção para criar um banco de dados SQL como arquivo diretamente no C#.


![banco](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Database.jpg)


Ao fazer isso, o Visual Studio automaticamente cria e integra o banco de dados completo ao projeto, facilitando o processo de desenvolvimento.

### 7.2

Com o banco de dados criado, precisamos adicionar uma classe chamada <b>AppDbContext.cs</b> dentro do /Models, para gerenciar as interações com o banco de dados.

Configurar a conexão no `Program.cs` e a string de conexão no `appsettings.json`

Baixar as dependências para interagir com o banco de dados:

- Microsoft.EntityFrameworkCore
  
- Microsoft.EntityFrameworkCore.Tools
  
- Microsoft.EntityFrameworkCore.Design
  
- Microsoft.EntityFrameworkCore.SqlServer

### 7.3 

Para testar se a conexão com o banco de dados estava funcionando corretamente, fiz os seguintes passos:

1- Criei uma classe chamada `User.cs` dentro do meu <b>/Models</b>

2- Criei uma table no banco de dados com os valores: `UserName, Password e Role`

3- Adicionei a linha de código que faz o teste da conexão:

![Teste](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Test_Database.jpg)

![Swagger](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Swagger_Databse_Teste.jpg)

Agora com o banco de dados pronto e funcionando, podemos seguir fazendo a criação das tabelas necessárias de acordo com o desafio proposto.

<div id='8'/>

# 8 Criar as regras de negócio

Nesta etapa comecei a fazer os ajustes nos códigos para definir as regras de negócio da forma que foi solicitada.

Regras:

Qualquer pessoa pode <b>Consultar todos os produtos cadastrados</b>

Qualquer pessoa pode <b>Consultar os produtos em estoque</b>

Somente o <b>Gerente</b> pode <b>Excluir</b> um produto

Somente o <b>Gerente</b> e o <b>Funcionário</b> podem <b>Atualizar</b> o estoque de um produto

[Código](https://github.com/Rodrigolppz/Squadra-API/blob/main/Teste%20API/Controllers/ProdutoController.cs)

<div id='9'/>

# 9 API & JSON DE EXEMPLO

As rotas do projeto estão separadas entre duas categorias: Aut e Produto.

Segue abaixo a lista das rotas configuradas para a conclusão do desafio:

![.](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Projeto%20API.jpg)

Explicação: 

1 - POST /api/Aut/login

Aqui é onde o usuário vai fazer um POST com seu UserName e Senha, se o username e senha estiverem de acordo com as credenciais de administrador ( admin / 123456 ), a resposta para essa requisição será um token de autenticação para a role <b>Gerente</b>, se o username = funcionario e senha = 123456, será gerado um token para a role funcionário. Caso não seja nenhum dos dois, será retornado a mensagem de "Credenciais inválidas"

```	
Response body - Json de exemplo

{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVXN1w6FyaW8iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJHZXJlbnRlIiwiZXhwIjoxNzMzNjgxMjg4LCJpc3MiOiJhcGktYXV0ZW50aWNhdGlvbiIsImF1ZCI6ImFwaS1jYWRhc3RybyJ9.Caw4iPu15orogKq8fr3XfgFE5NSLtyuzB1ci5hgMZTk"
}
```



2 - GET /api/Produto

Nesse método GET /api/Produto o usuário vai receber como resposta todos os produtos que existem no programa, independentemente se este produto está com status "em-estoque" ou não.

```
[
  {
    "id": 1,
    "nome": "ar-condicionado",
    "descricao": "o melhor do mercado",
    "status": "em-estoque",
    "preco": 1200,
    "quantidadeEstoque": 12
  },
  {
    "id": 2,
    "nome": "Televisão",
    "descricao": "70 polegadas",
    "status": "em-estoque",
    "preco": 1500,
    "quantidadeEstoque": 3
  },
  {
    "id": 3,
    "nome": "Sofá",
    "descricao": "Sofá de couro",
    "status": "esgotado",
    "preco": 2675,
    "quantidadeEstoque": 0
  }
]
```

3 - POST /api/Produto

O usuário vai adicionar um novo produto ao estoque, esse produto precisa ter um ID diferente dos outros produtos que já existem no estoque, qualquer usuário pode realizar esse post.

```
{
  "id": 0,
  "nome": "string",
  "descricao": "string",
  "status": "string",
  "preco": 0,
  "quantidadeEstoque": 0
}
```

4 - GET /api/Produto/em-estoque

Aqui serão listados somente os produtos que possuem o atual status = "em-estoque", do contrário o produto não irá aparecer nessa parte.

```
[
  {
    "id": 1,
    "nome": "ar-condicionado",
    "descricao": "o melhor do mercado",
    "status": "em-estoque",
    "preco": 1200,
    "quantidadeEstoque": 12
  },
  {
    "id": 2,
    "nome": "Televisão",
    "descricao": "70 polegadas",
    "status": "em-estoque",
    "preco": 1500,
    "quantidadeEstoque": 15
  }
]
```


5 - PUT /api/Produto/{id}

Nessa rota o usuário vai alterar a quantidade em estoque de um determinado produto, somente as roles <b>Gerente</b> e <b>Funcionário</b> tem permissão para fazer essa alteração


6 - DELETE /api/Produto/{id}

Aqui o usuário poderá deletar qualquer produto da tabela apenas especificando o ID, somente a role <b>Gerente</b> tem essa permissão.


--------------------------------------------------------------------------------------------------------

<div id='10'/>

# Como executar a API

### 1 Git clone

Crie uma arquivo e dentro dele execute no git bash: `git clone https://github.com/Rodrigolppz/Squadra-API.git`

### 2 Abrir o projeto no Visual Studio

- Abra o arquivo `(Teste API.sln)` 

### 3 Configurar o banco de dados

Clique em `Tools -> Connect to Database -> Microsoft SQL Server Database File(SqlClient)` Clique em Browse e selecione o DatabaseSQL.mdf que está na pasta Database

Vá até o canto superior esquerdo em DatabaseSQL.mdf -> botão direito -> Properties -> Connection string e copie tudo o que vem depois do connection string.

Depois vá até  `appsettings.json` e cole o connection string após o  "DefaultConnection" 

### 4 Compilar e rodar o projeto

- No Visual Studio, selecione o projeto Teste API como Startup Project.

- Clique em Executar ou (CTRL + F5)

### 5 Testar a API usando o Postman ou Swagger

- Ao iniciar o projeto, basta testar a API fazendo um POST,GET,UPDATE e DELETE!



