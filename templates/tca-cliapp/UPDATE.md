# Atualizando o modelo

Este modelo é baseado no modelo genérico `console`, porém com modificações para
adequar-se a _TheCleanArch_. E para isso acrescentamos o modelo descrito no
tutorial de introdução da biblioteca `System.CommandLine`.

https://learn.microsoft.com/pt-br/dotnet/standard/commandline/get-started-tutorial

Sempre que for atualizar o modelo, recomendamos excluir este totalmente, gerar
o modelo base com o comando abaixo:
```sh
dotnet new console -n TheCleanArch.Templates.CliApp -o tca-cliapp
```

E por fim aplicar as mudanças, que são:

- Referência as bibliotecas `TheCleanArch.InterfaceAdapter` e `System.CommandLine`
- Simplificação do cabeçalho do projeto em `TheCleanArch.Templates.CliApp.csproj`
```xml
<PropertyGroup>
  <OutputType>Exe</OutputType>
  <TargetFramework>net10.0</TargetFramework>
</PropertyGroup>
```
- Adicione conteúdo ao projeto em `TheCleanArch.Templates.CliApp.csproj`
```xml
<ItemGroup>
  <!-- Arquivos do projeto que devem ser publicados com o aplicativo-->
  <Content Include="sampleQuotes.txt">
    <CopyToOutputDirectory>Always</CopyToOutputDirectory>
  </Content>
</ItemGroup>
```
- O `{GUID}` deve ser referenciado em `.template.config/template.json#/guids`
- Novos arquivos `AssemblyInfo.cs` e `Usings.cs`
