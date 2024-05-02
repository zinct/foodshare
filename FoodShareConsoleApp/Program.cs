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
            Console.WriteLine("Sharefood: Aplikasi Mengurangi Indeks Kelaparan");
            Console.WriteLine("1. Tambah Makanan");
            Console.WriteLine("2. Edit Makanan");
            Console.WriteLine("3. Hapus Makanan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
            Console.Write("Silahkan inputkan kode menu: ");

            // Get input code from user
            int inputCode = int.Parse(Console.ReadLine());

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

class CreateFoodMenuState : IMenuState
{
    public void HandleOutput(MenuContext context)
    {
        Console.WriteLine("Masukan Nama: ");
        String name = Console.ReadLine();
        Console.WriteLine("Expire: ");
        String expire = Console.ReadLine();
        Console.WriteLine("Quantity: ");
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