# Atualizando o modelo

Este modelo é baseado no modelo genérico `blazor`, porém com algumas
modificações para adequar-se a _TheCleanArch_.

Sempre que for atualizar o modelo, recomendamos excluir este totalmente, gerar
o modelo base com o comando abaixo:
```sh
dotnet new blazor -n TheCleanArch.Templates.WebApp -o tca-webapp
```

E por fim aplicar as mudanças, que são:

- Referência a biblioteca `TheCleanArch.InterfaceAdapter`
- Simplificação do cabeçalho do projeto em `TheCleanArch.Templates.WebApp.csproj`
```xml
<PropertyGroup>
  <TargetFramework>net10.0</TargetFramework>
  <BlazorDisableThrowNavigationException>true</BlazorDisableThrowNavigationException>
</PropertyGroup>
```
- Novos arquivos `AssemblyInfo.cs` e `Usings.cs`
- As portas padronizadas em `Properties/launchSettings.json`
  - HTTP para `8080`
  - HTTPS para `8443`
