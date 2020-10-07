# entra21-tests

### Méotodos
#### Definindo o retorno
    // int é o tipo referente ao valor retornado
    public int Exercise()
    {
      return 0;
    }

    // string é o tipo referente ao valor retornado
    public int Exercise()
    {
      return "test";
    }

### Rodando os testes
#### Todos os testes:
    dotnet test

#### Um teste específico:
    dotnet test --filter "FullyQualifiedName=<namespace>.<class>.<test>"

### Organizando o repositório
#### Criar um novo projeto para alocar as classes de Dominio:
    dotnet new classlib -f netcoreapp3.1
Obs: O comando deve ser rodado dentro da pasta "Domain"

#### Adicionar a dependencia do projeto "Domain" dentro do projeto "Tests":
    dotnet add Tests/Tests.csproj reference Domain/Domain.csproj
Obs: O comando deve ser rodado dentro da pasta principal do repositório
