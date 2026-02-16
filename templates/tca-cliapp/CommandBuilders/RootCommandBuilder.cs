// TODO: Add copyright file header here

namespace TheCleanArch.Templates.CliApp.CommandBuilders;

public class RootCommandBuilder : CommandBuilder<RootCommandBuilder>
{
    public RootCommand Build()
    {
        RootCommand rootCommand = new("Sample app for System.CommandLine");

        rootCommand.Options.Add(CommonOptions.FileOption);

        SubCommands.ForEach(rootCommand.Subcommands.Add);

        return rootCommand;
    }
}
