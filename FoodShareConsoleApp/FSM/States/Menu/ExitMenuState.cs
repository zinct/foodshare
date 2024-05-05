using FoodShareConsoleApp.FSM.Contexts;
using FoodShareConsoleApp.FSM.Interfaces;

namespace FoodShareConsoleApp.FSM.States.Menu
{
    class ExitMenuState : IMenuState
    {
        public Task HandleOutput(MenuContext context)
        {
            Console.WriteLine("Aplikasi keluar!");
            Environment.Exit(0);
            return Task.CompletedTask;
        }
    }

}
