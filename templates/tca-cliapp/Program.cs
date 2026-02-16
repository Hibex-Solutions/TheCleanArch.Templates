// TODO: Add copyright file header here

var readCommand = new ReadCommandBuilder().Build();
var deleteCommand = new DeleteCommandBuilder().Build();
var addCommand = new AddCommandBuilder().Build();

var quotesCommand = new QuotesCommandBuilder()
    .AddSubCommand(readCommand)
    .AddSubCommand(deleteCommand)
    .AddSubCommand(addCommand)
    .Build();

return new RootCommandBuilder()
    .AddSubCommand(quotesCommand)
    .Build()
    .Parse(args)
    .Invoke();
