// TODO: Add copyright file header here

namespace TheCleanArch.Templates.CliApp;

/// <summary>
/// Define opções comuns para todos os comandos aqui. Dessa forma, podemos
/// reutilizar a mesma opção em vários comandos sem precisar redefini-la.
/// </summary>
public static class CommonOptions
{
    public static Option<FileInfo> FileOption = new("--file")
    {
        Description = "An option whose argument is parsed as a FileInfo",
        Required = true,

        // NOTE: Não esqueça dessa opção. Ela permite ser usada em subcomandos
        Recursive = true,
        DefaultValueFactory = result =>
        {
            if (result.Tokens.Count == 0)
            {
                return new FileInfo("sampleQuotes.txt");
            }

            string filePath = result.Tokens.Single().Value;

            if (!File.Exists(filePath))
            {
                result.AddError("File does not exist");
                return null;
            }
            else
            {
                return new FileInfo(filePath);
            }
        }
    };
}
