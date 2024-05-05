using FoodShareConsoleApp.FSM.Contexts;

namespace FoodShareConsoleApp.FSM.Interfaces
{
    public interface IMenuState
    {
        public Task HandleOutput(MenuContext context);
    }
}
