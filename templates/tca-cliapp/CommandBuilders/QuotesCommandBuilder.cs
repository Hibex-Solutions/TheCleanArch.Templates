// TODO: Add copyright file header here

namespace TheCleanArch.Templates.CliApp.CommandBuilders;

public class QuotesCommandBuilder : CommandBuilder<QuotesCommandBuilder>
{
    public Command Build()
    {
        Command command = new("quotes", "Work with a file that contains quotes.");

        SubCommands.ForEach(command.Subcommands.Add);

        return command;
    }
}
