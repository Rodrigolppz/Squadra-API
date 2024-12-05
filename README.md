### <h1 align=center> SQUADRA <img src="https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Squadra-logo.jpg" alt="Descrição da imagem" width="30"> - Projeto API RestFUL | .NET - C# </h1>

### Desafio: 
Desenvolver um sistema <b>Gerenciador de produtos</b>, a ideia é desenvolver uma API de produtos seguindo as boas práticas de desenvolvimento utilizando ASP.NET Core.

Abaixo irei detalhar o passo a passo da criação dessa API.

#


### 1 - Criar o projeto no Visual Studio.

Nesse primeiro passo é importante criar o projeto da maneira certa, para isso basta ir até o Visual studio que foi instalado `Visual studio -> Create a new project -> ASP.NET Core Web API -> Create`

![Imagem](https://github.com/Rodrigolppz/Squadra-API/blob/main/images/Asp.net.jpg)

Com essa instalação o Visual Studio já deixa o nosso ambiente preparado e facilita bastante o trabalho na hora de desenvolvermos a nossa API.

### 2 - Instalação dos pacotes adicionais do Visual Studio
.

.

.

.



### 3 - Organizar os diretórios dentro do projeto

Esta é a etapa inicial do projeto, é aqui que damos o primeiro passo em direção à construção da nossa API.

Para realizar o desafio eu organizei o projeto em 3 pastas:


/Controllers 

/Models

/Services

Explicação:

<b>Controllers</b>: São responsáveis por receber as requisições HTTP, interpretá-las e chamar as funções adequadas dos serviços correspondentes. Eles lidam com a entrada e saída da aplicação, mapeando os endpoints da API para as funções apropriadas.

<b>Models</b>: Models são os responsáveis por representar as entidades da API. Aqui é onde definimos as estruturas que representam os dados utilizados na aplicação.

<b>Services</b>: São responsáveis por armazenar todas as regras de negócio. É onde agrupamos todos os métodos que serão chamados pelos controllers.

### 4 - Criação das classes

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

### 5 - Let's Code

Agora com a estrutura do nosso projeto feita, vamos começar a por a mão na massa.

Por se tratar de diversos códigos, achei melhor deixar essa parte para ser analisada direto no projeto real

Clique aqui para ser redirecionado para os códigos da aplicação -> [Códigos API](...)

### 6 - JWT Token

Após codar a estrutura da API, precisamos aplicar as boas práticas e garantir que ela seja segura, Para isso, utilizamos o JWT Token (JSON Web Token) que nada mais é do que uma autenticação de segurança.

Funciona dessa forma: O cliente faz uma requisição do tipo post, a API gera um token e devolve como resposta para o cliente. A partir disso o cliente tem porta aberta para fazer as demais requisições.






