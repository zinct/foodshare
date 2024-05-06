using Spectre.Console;
using FoodShareConsoleApp.FSM.Contexts;


internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            // Initialize State Machine / Context
            MenuContext context = new MenuContext();

            while (true)
            {
                 await context.HandleOutput();
            }
        } catch(Exception e)
        {
            Console.WriteLine("Somethin went wrong {0}", e.Message);
        }
        
    }
}

class ConsoleUtils
{
    public static T Ask<T>(String text, String type)
    {
        AnsiConsole.Write(new Rule($"[yellow]{type}[/]").RuleStyle("grey").LeftJustified());
        T answer = AnsiConsole.Prompt(
                        new TextPrompt<T>(text)
                            .PromptStyle("green")
                    );
        AnsiConsole.WriteLine();

        return answer;
    }

    public static T AskValidation<T>(String text, String type, Func<T, bool> Validation, String errorMessage)
    {
        AnsiConsole.Write(new Rule($"[yellow]{type}[/]").RuleStyle("grey").LeftJustified());
        T answer = AnsiConsole.Prompt(
                    new TextPrompt<T>(text)
                        .PromptStyle("green")
                        .ValidationErrorMessage("[red]That's not a valid age[/]")
                        .Validate(value =>
                        {
                            if (!Validation(value))
                            {
                                AnsiConsole.WriteLine();
                                return ValidationResult.Error($"[red]{errorMessage}[/]");
                            }

                            return ValidationResult.Success();
                        }));
        AnsiConsole.WriteLine();
        return answer;
    }

    public static Task ProgressBar(String label, int delay)
    {
        return AnsiConsole.Progress()
            .Columns(new ProgressColumn[]
            {
                    new TaskDescriptionColumn(),
                    new ProgressBarColumn(),
                    new PercentageColumn(),
                    new SpinnerColumn(),
            })
            .StartAsync(async ctx =>
            {
                var task1 = ctx.AddTask("[green]" + label + "[/]");


                while (!ctx.IsFinished)
                {
                    await Task.Delay(delay);

                    // Increment
                    task1.Increment(10);
                }

            });
    }

    public static T AskSelection<T>(String text, String type, T[] choices)
    {
        AnsiConsole.Write(new Rule($"[yellow]{type}[/]").RuleStyle("grey").LeftJustified());
        T answer = AnsiConsole.Prompt(
                    new SelectionPrompt<T>()
                        .Title(text)
                        .PageSize(choices.Length)
                        .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                        .AddChoices(choices));
        AnsiConsole.WriteLine();

        return answer;
    }
}
