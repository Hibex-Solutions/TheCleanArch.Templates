# Atualizando o modelo

Este modelo é baseado no modelo genérico `console`, porém com várias modificações
para adequar-se ao uso com biblioteca _TUnit_ e aos padrões _TheCleanArch_.

Sempre que for atualizar o modelo, recomendamos excluir este totalmente, gerar
o modelo base nas instruções a seguir:
```sh
dotnet new console -n TheCleanArch.Templates.UnitTest -o tca-unittest
cd tca-unittest
dotnet package add TUnit
```

- Referência a biblioteca `TheCleanArch.Core`
- Simplificação do cabeçalho do projeto em `TheCleanArch.Templates.UnitTest.csproj`
```xml
<PropertyGroup>
  <OutputType>Exe</OutputType>
  <TargetFramework>net10.0</TargetFramework>
</PropertyGroup>
```
- Removemos `Program.cs`
- Novos arquivos `global.json`, `AssemblyInfo.cs` e `Usings.cs`
- Novos arquivos com exemplos de testes