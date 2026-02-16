// TODO: Add copyright file header here

namespace TheCleanArch.Templates.CliApp.CommandBuilders;

public class ReadCommandBuilder : CommandBuilder<ReadCommandBuilder>
{
    private static Option<int> _delayOption = new("--delay")
    {
        Description = "Delay between lines, specified as milliseconds per character in a line",
        DefaultValueFactory = parseResult => 42
    };

    private static Option<ConsoleColor> _fgcolorOption = new("--fgcolor")
    {
        Description = "Foreground color of text displayed on the console",
        DefaultValueFactory = parseResult => ConsoleColor.White
    };

    private static Option<bool> _lightModeOption = new("--light-mode")
    {
        Description = "Background color of text displayed on the console: default is black, light mode is white"
    };

    private static void Handle(FileInfo file, int delay, ConsoleColor fgColor, bool lightMode)
    {
        Console.BackgroundColor = lightMode ? ConsoleColor.White : ConsoleColor.Black;
        Console.ForegroundColor = fgColor;

        foreach (string line in File.ReadLines(file.FullName))
        {
            Console.WriteLine(line);
            Thread.Sleep(TimeSpan.FromMilliseconds(delay * line.Length));
        }
    }

    public Command Build()
    {
        Command command = new("read", "Read and display the file.")
        {
            _delayOption,
            _fgcolorOption,
            _lightModeOption
        };

        SubCommands.ForEach(command.Subcommands.Add);

        command.SetAction(parseResult => Handle(
            parseResult.GetValue(CommonOptions.FileOption),
            parseResult.GetValue(_delayOption),
            parseResult.GetValue(_fgcolorOption),
            parseResult.GetValue(_lightModeOption)));

        return command;
    }
}
