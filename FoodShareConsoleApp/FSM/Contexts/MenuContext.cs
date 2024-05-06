using FoodShareConsoleApp.FSM.Interfaces;
using FoodShareConsoleApp.FSM.States.Menu;
using FoodShareCore.Utilities;

namespace FoodShareConsoleApp.FSM.Contexts
{
    public enum MenuTrigger
    {
        ReadMenu,
        CreateMenu,
        EditMenu,
        ShowMenu,
        Back,
    }

    public class MenuContext
    {
        public IMenuState currentState = new InitialMenuState();
        public IMenuState previousState = new InitialMenuState();

        

        public class Transition
        {
            public IMenuState initialState;
            public IMenuState nextState;
            public MenuTrigger trigger;

            public Transition(IMenuState initialState, IMenuState nextState, MenuTrigger trigger)
            {
                this.initialState = initialState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        private Transition[] transitions =
        {
            new Transition(new InitialMenuState(), new ReadFoodMenuState(), MenuTrigger.ReadMenu),
            new Transition(new ReadFoodMenuState(), new InitialMenuState(), MenuTrigger.Back),
            new Transition(new InitialMenuState(), new CreateFoodMenuState(), MenuTrigger.CreateMenu),
            new Transition(new CreateFoodMenuState(), new InitialMenuState(), MenuTrigger.Back),
            new Transition(new InitialMenuState(), new ExitMenuState(), MenuTrigger.Back),
        };

        public IMenuState GetNextState(IMenuState currentState, MenuTrigger trigger)
        {
            IMenuState nextState = currentState;
            for (int i = 0; i < transitions.Length; i++)
            {
                Transition transition = transitions[i];
                if (currentState.GetType() == transition.initialState.GetType() && trigger == transition.trigger)
                {
                    nextState = transition.nextState;
                }
            }

            return nextState;
        }

        public async Task ActiveTrigger(MenuTrigger trigger)
        {
            Console.WriteLine("State LOG From: " + currentState.ToString());

            currentState = GetNextState(currentState, trigger);
            
            Console.WriteLine("State LOG To: " + currentState.ToString());
            Console.WriteLine();
            Console.WriteLine();

            await currentState.HandleOutput(this);
        }

        public async Task HandleOutput()
        {
            await currentState.HandleOutput(this);
        }
    }

}
