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

### 4 - Let's Code 

Nessa etapa é onde começamos a desenvolver os códigos da nossa aplicação. Para isso, precisamos criar algumas classes, segue abaixo a estrutura:

/Controllers

- ProdutoController.cs

/Models

- Produto.cs

- User.cs

/Services

- ProdutoService.cs
  
- UserService.cs


------------------------

Program.cs

Seguindo a explicação que foi feita acima, nós definimos o começo da estrutura do nosso projeto.

Detalhe: O program.cs já é criado automaticamente quando iniciamos o projeto, ele é o arquivo central, onde os principais códigos e configurações do aplicativo são executados. 



