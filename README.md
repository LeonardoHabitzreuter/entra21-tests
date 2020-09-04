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
