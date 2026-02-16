# Atualizando o modelo

Este modelo é baseado no modelo genérico `worker`, porém com algumas
modificações para adequar-se a _TheCleanArch_.

Sempre que for atualizar o modelo, recomendamos excluir este totalmente, gerar
o modelo base com o comando abaixo:
```sh
dotnet new worker -n TheCleanArch.Templates.WorkerService -o tca-workerservice
```

E por fim aplicar as mudanças, que são:

- Referência a biblioteca `TheCleanArch.InterfaceAdapter`
- Simplificação do cabeçalho do projeto em `TheCleanArch.Templates.WorkerService.csproj`
```xml
<PropertyGroup>
  <TargetFramework>net10.0</TargetFramework>
  <UserSecretsId>TheCleanArch.Templates.WorkerService-{GUID}</UserSecretsId>
</PropertyGroup>
```
- O `{GUID}` deve ser referenciado em `.template.config/template.json#/guids`
- Novos arquivos `AssemblyInfo.cs` e `Usings.cs`
