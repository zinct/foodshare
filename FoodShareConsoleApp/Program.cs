using Spectre.Console;
using System.Drawing;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

interface IMenuState
{
    public void HandleOutput(MenuContext context);
}

class MenuContext
{
    public IMenuState currentState;

    public MenuContext(IMenuState currentState)
    {
        this.currentState = currentState;
    }

    public void ChangeState(IMenuState newState)
    {
        currentState = newState;
        currentState.HandleOutput(this);
    }

    public void HandleOutput()
    {
        currentState.HandleOutput(this);
    }
}


class InitialMenuState : IMenuState
{
    public void HandleOutput(MenuContext context)
    {
        try
        {
            AnsiConsole.Write(new Markup("[bold green1]Sharefood:[/] Aplikasi mengurangi indeks kelaparan di indonesia!"));
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Markup("1. Tambah makanan"));
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Markup("2. Edit makanan"));
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Markup("3. Hapus makanan"));
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Markup("0. Keluar makanan"));
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine();

            // Get input code from user
            int inputCode = ConsoleUtils.Ask<int>("Silahkan inputkan kode menu!", "Numeric");

            Console.Clear();

            if (inputCode == 0)
            {
                context.ChangeState(new ExitMenuState());
            }
            else if (inputCode == 1)
            {
                context.ChangeState(new CreateFoodMenuState());
            }
            else if (inputCode == 2)
            {

            }
        }
        catch (Exception e)
        {
            
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
                            if(!Validation(value))
                            {
                                AnsiConsole.WriteLine();
                                return ValidationResult.Error($"[red]{errorMessage}[/]");
                            }

                            return ValidationResult.Success();
                        }));
        AnsiConsole.WriteLine();
        return answer;
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

class CreateFoodMenuState : IMenuState
{
    public void HandleOutput(MenuContext context)
    {
        bool isQuestioning = true;

        while(isQuestioning)
        {
            AnsiConsole.Write(new Table().AddColumns("[grey]Form Pendaftaran Data Makanan[/]")
                .RoundedBorder()
                .BorderColor(Spectre.Console.Color.Green1));

            String name = ConsoleUtils.Ask<String>("Masukan nama makanan?", "String");
            String description = ConsoleUtils.Ask<String>("Masukan deskripsi makanan?", "String");
            String expire = ConsoleUtils.AskValidation<String>("Masukan tanggal kadaluarsa? [yellow](ex. 30-01-2003)[/]", "String",
                value =>
                {
                    return true;
                },
                "Format tanggal tidak valid!");

            int amount = ConsoleUtils.Ask<int>("Masukan jumlah makanan?", "Integer");

            String condition = ConsoleUtils.AskSelection<String>("Masukan kondisi makanan?", "Choices", new String[] { "Baik", "Cukup", "Buruk" });
            String source = ConsoleUtils.AskSelection<String>("Masukan sumber makanan?", "Choices", new String[] { "Restoran", "Kafe", "Minimarket", "Toko Kelontong", "Pasar", "Hotel", "Katering", "Kantin", "Toko Roti / Kue" });
            String category = ConsoleUtils.AskSelection<String>("Masukan kategori makanan?", "Choices", new String[] { "Daging", "Ayam", "Ikan / Produk Laut", "Sayuran", "Buah Buahan", "Biji Bijian", "Susu", "Roti / Kue", "Cemilan", "Siap Saji" });

            AnsiConsole.Clear();

            AnsiConsole.Write(new Table().AddColumns("[grey]Pertanyaan[/]", "[grey]Jawaban[/]")
                    .RoundedBorder()
                    .BorderColor(Spectre.Console.Color.Grey)
                    .AddRow("[grey]Nama[/]", name)
                    .AddRow("[grey]Deskripsi[/]", description)
                    .AddRow("[grey]Kadaluarsa[/]", expire)
                    .AddRow("[grey]Jumlah[/]", amount.ToString())
                    .AddRow("[grey]Kondisi[/]", condition)
                    .AddRow("[grey]Sumber Makanan[/]", source)
                    .AddRow("[grey]Kategori[/]", category));

            AnsiConsole.WriteLine();
            if (AnsiConsole.Confirm("Apakah data yang anda inputkan adalah benar?"))
            {
                AnsiConsole.MarkupLine("Ok... :(");
                break;
            }

            AnsiConsole.Clear();
        }

        context.ChangeState(new InitialMenuState());
    }
}

class ExitMenuState : IMenuState
{
    public void HandleOutput(MenuContext context)
    {
        Console.WriteLine("Aplikasi keluar!");
        Environment.Exit(0);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        
        try
        {
            // Initialize State Machine / Context
            MenuContext context = new MenuContext(new InitialMenuState());

            while (context.currentState is not ExitMenuState)
            {
                context.HandleOutput();
            }

        } catch(Exception e)
        {
            Console.WriteLine("Somethin went wrong {0}", e.Message);
        }
        
    }
}



//public class ConsoleStateMachine
//{
//    public enum ConsoleState { MainMenu, CreateFood, EditFood, DeleteFood, Exit };
//    public enum Action { CreateMenu, EditMenu, DeleteMenu, Back };

//    public ConsoleState currentState = ConsoleState.MainMenu;

//    public class Transition
//    {
//        public ConsoleState currentState;
//        public ConsoleState previousState;
//        public Action action;

//        public Transition(ConsoleState initialState, ConsoleState previousState, Action action)
//        {
//            this.currentState = initialState; 
//            this.previousState = previousState;
//            this.action = action;
//        }
//    }

//    Transition[] transitions =
//    {
//            new Transition(ConsoleState.MainMenu, ConsoleState.CreateFood, Action.CreateMenu),
//    };

//    public static Action GetAction(int code)
//    {
//        Action[] menus = { Action.Back, Action.CreateMenu, Action.EditMenu, Action.DeleteMenu };
//        return menus[code];
//    }

//    public ConsoleState GetNextState(ConsoleState state, Action action)
//    {
//        ConsoleState previousState = state;

//        for (int i = 0; i < transitions.Length; i++)
//        {
//            Transition transition = transitions[i];

//            if (state == transition.currentState && action == transition.action)
//            {
//                previousState = transition.previousState;
//            }
//        }

//        return previousState;
//    }

//    public void ActiveAction(Action action)
//    {
//        currentState = GetNextState(currentState, action);
//    }
//}