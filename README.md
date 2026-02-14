# The Clean Arch Templates .NET

Modelos para projetos _.NET_ baseados em [_TheCleanArch_][THECLEANARCH].

Você pode aprender em https://hibex-solutions.github.io/TheCleanArch/.

## Início rápido

Instale os modelos:
```sh
dotnet new install TheCleanArch.Templates
```

Você pode conferir todos nossos modelos disponíveis assim:
```sh
dotnet new list --tag TheCleanArch
```

Se quiser aprender mais sobre cada um:
```sh
dotnet new {template-name} --help
```

Agora basta criar seus projetos usando os modelos:
```sh
dotnet new {template-name} [...parâmetros]
```

## Desenvolvendo

Instale os modelos localmente:
```sh
dotnet new install .
```

Todos os comandos para obter ajuda e listar os modelos do início rápido se aplicam aqui.

Sempre que quiser desinstale-os:
```sh
dotnet new uninstall .
```

## Desenvolvendo com DevContainer

1. Habilite SSH Agent antes de entrar no Dev Container
    - https://code.visualstudio.com/remote/advancedcontainers/sharing-git-credentials
2. Adicione suas chaves
```sh
ssh-add $HOME/.ssh/{sua_chave}
```


<!-- links -->

[THECLEANARCH]: https://github.com/Hibex-Solutions/TheCleanArch