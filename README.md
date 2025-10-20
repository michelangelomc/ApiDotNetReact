# ApiDotNetReact
Integração API .NetCore9 com React
- Estudo de como integrar o React com .Net9
- Clean Code
- Arquitetura Limpa
- Segregação de responsabilidades

echo "# ApiDotNetReact" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/michelangelomc/ApiDotNetReact.git
git push -u origin main


Singleton: Isso cria apenas uma instância de uma classe durante o ciclo de vida do aplicativo. Toda vez que você solicita essa classe, você obtém a mesma instância. Use-o para classes que são caras de criar ou manter um estado comum em todo o aplicativo, como uma conexão com o banco de dados.

Transient: Toda vez que você solicita uma classe transitória, uma nova instância é criada. Isso é útil para serviços leves e sem estado, onde cada operação requer uma instância limpa e independente.

Scoped: Instâncias com escopo são criadas uma vez por solicitação do cliente. Em um aplicativo web, por exemplo, uma nova instância é criada para cada solicitação HTTP, mas é compartilhada durante essa solicitação. Use-o para serviços que precisam manter o estado dentro de uma so


## Technologies

* ASP.NET Core 5
* [Entity Framework Core 5](https://docs.microsoft.com/en-us/ef/core/)
* [Angular 10](https://angular.io/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)
* [NUnit](https://nunit.org/), [FluentAssertions](https://fluentassertions.com/), [Moq](https://github.com/moq) & [Respawn](https://github.com/jbogard/Respawn)
* [Docker](https://www.docker.com/)


Comandos EF:
-> verifica a instalação: dotnet ef
-> instala o EF: dotnet tool install --global dotnet-ef
-> atualiza o EF: dotnet tool update --global dotnet-ef
-> executa migrations: dotnet ef migrations add cria_tb_indentity --verbose
-> remove o migrations: dotnet ef migrations remove
-> aplica migrations: dotnet ef database update --verbose

 
Gera um token no prompt de comando:
-->  dotnet user-jwts create

--> Xunit => https://xunit.net/docs/getting-started/v3/getting-started

Clena Architecture:
 -> Independente de Frameworks
 -> Testável
 -> Independente da camada de apresentação
 -> Indepentedente do Banco de Dados
 -> Independentete de fatores externos
 
 
 O servidor de aplicação web para .NET 9 (e outras versões do ASP.NET Core) é o Kestrel.

Comando para publicar:
  -> dotnet publish -f net8.0 -c Release
  