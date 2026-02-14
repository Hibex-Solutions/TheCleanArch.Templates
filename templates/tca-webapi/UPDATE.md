# Atualizando o modelo

Este modelo é baseado no modelo genérico `webapi`, porém com algumas
modificações para adequar-se a _TheCleanArch_.

Sempre que for atualizar o modelo, recomendamos excluir este totalmente, gerar
o modelo base com o comando abaixo:
```sh
dotnet new webapi -n TheCleanArch.Templates.WebApi -o tca-webapi
```

E por fim aplicar as mudanças, que são:

- Referência a biblioteca `TheCleanArch.InterfaceAdapter`
- Simplificação do cabeçalho do projeto em `TheCleanArch.Templates.WebApi.csproj`
```xml
<PropertyGroup>
  <TargetFramework>net10.0</TargetFramework>
</PropertyGroup>
```
- Novos arquivos `AssemblyInfo.cs` e `Usings.cs`
- Um `Program.cs` mais limpo, apenas com uma rota `app.MapGet("/", () => "Hello World!");`
- As portas padronizadas em `Properties/launchSettings.json`
  - HTTP para `5000`
  - HTTPS para `5443`
  - Também deve ser atualizado em `TheCleanArch.Templates.WebApi.http`
