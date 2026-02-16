// TODO: Add copyright file header here

namespace TheCleanArch.Templates.CliApp.CommandBuilders;

public class DeleteCommandBuilder : CommandBuilder<DeleteCommandBuilder>
{
    private static Option<string[]> _searchTermsOption = new("--search-terms")
    {
        Description = "Strings to search for when deleting entries",
        Required = true,
        AllowMultipleArgumentsPerToken = true
    };

    private static void Handle(FileInfo file, string[] searchTerms)
    {
        Console.WriteLine("Deleting from file");

        var lines = File.ReadLines(file.FullName).Where(line => searchTerms.All(s => !line.Contains(s)));

        File.WriteAllLines(file.FullName, lines);
    }

    public Command Build()
    {
        Command command = new("delete", "Delete lines from the file.");

        command.Options.Add(_searchTermsOption);

        SubCommands.ForEach(command.Subcommands.Add);

        command.SetAction(parseResult => Handle(
            parseResult.GetValue(CommonOptions.FileOption),
            parseResult.GetValue(_searchTermsOption)));

        return command;
    }
}
