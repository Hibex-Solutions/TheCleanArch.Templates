// TODO: Add copyright file header here

namespace TheCleanArch.Templates.CliApp;

public class CommandBuilder<T> where T : CommandBuilder<T>
{
    private readonly List<Command> _subCommands = new();

    public List<Command> SubCommands => _subCommands;

    public T AddSubCommand(Command command)
    {
        Guard.NotNullArgument(command, nameof(command));

        SubCommands.Add(command);

        return this as T;
    }
}
