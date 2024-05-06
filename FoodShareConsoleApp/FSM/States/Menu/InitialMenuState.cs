using Spectre.Console;
using FoodShareConsoleApp.FSM.Interfaces;
using FoodShareConsoleApp.FSM.Contexts;


namespace FoodShareConsoleApp.FSM.States.Menu
{
    class InitialMenuState : IMenuState
    {
        public async Task HandleOutput(MenuContext context)
        {
            try
            {
                AnsiConsole.Write(new Markup("[bold green1]Sharefood:[/] Aplikasi mengurangi indeks kelaparan di indonesia!"));
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new Markup("1. Lihat makanan"));
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new Markup("2. Tambah makanan"));
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new Markup("3. Edit makanan"));
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new Markup("4. Hapus makanan"));
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new Markup("0. Keluar makanan"));
                AnsiConsole.WriteLine();
                AnsiConsole.WriteLine();

                // Get input code from user
                int inputCode = ConsoleUtils.Ask<int>("Silahkan inputkan kode menu!", "Numeric");

                Console.Clear();

                if (inputCode == 0)
                {
                    await context.ActiveTrigger(MenuTrigger.Back);
                }
                else if (inputCode == 1)
                {
                    await context.ActiveTrigger(MenuTrigger.ReadMenu);
                }
                else if (inputCode == 2)
                {
                    await context.ActiveTrigger(MenuTrigger.CreateMenu);
                }
                else if (inputCode == 3)
                {
                    await context.ActiveTrigger(MenuTrigger.EditMenu);
                }
                else if (inputCode == 4)
                {
                    await context.ActiveTrigger(MenuTrigger.DeleteMenu);
                }
            }
            catch (Exception e)
            {

            }
        }
    }

}
