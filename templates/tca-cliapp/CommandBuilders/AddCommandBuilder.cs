// TODO: Add copyright file header here

namespace TheCleanArch.Templates.CliApp.CommandBuilders;

public class AddCommandBuilder : CommandBuilder<AddCommandBuilder>
{
    private static Argument<string> _quoteArgument = new("quote")
    {
        Description = "Text of quote."
    };

    private static Argument<string> _bylineArgument = new("byline")
    {
        Description = "Byline of quote."
    };

    private static void AddToFile(FileInfo file, string quote, string byline)
    {
        Console.WriteLine("Adding to file");

        using StreamWriter writer = file.AppendText();

        writer.WriteLine($"{Environment.NewLine}{Environment.NewLine}{quote}");
        writer.WriteLine($"{Environment.NewLine}-{byline}");
    }

    public Command Build()
    {
        Command command = new("add", "Add an entry to the file.");

        command.Arguments.Add(_quoteArgument);
        command.Arguments.Add(_bylineArgument);

        command.Aliases.Add("insert");

        SubCommands.ForEach(command.Subcommands.Add);

        command.SetAction(parseResult => AddToFile(
            parseResult.GetValue(CommonOptions.FileOption),
            parseResult.GetValue(_quoteArgument),
            parseResult.GetValue(_bylineArgument)));

        return command;
    }
}
