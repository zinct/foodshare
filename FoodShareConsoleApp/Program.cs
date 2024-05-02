internal class Program
{
    public class MenuCode
    {
        //public const static int CREATE_MENU = 0;
    }
    private static void Main(string[] args)
    {
        // Initialize State Machine
        ConsoleStateMachine stateMachine = new ConsoleStateMachine();

        while(stateMachine.currentState != ConsoleState.EXIT)
        {
            Console.WriteLine("Sharefood: Aplikasi Mengurangi Indeks Kelaparan");
            Console.WriteLine("1. Tambah Makanan");
            Console.WriteLine("2. Edit Makanan");
            Console.WriteLine("3. Hapus Makanan");
            Console.WriteLine("4. Keluar");

            Console.Write("Silahkan inputkan no menu! ");
            String inputCode = Console.ReadLine();

            if(inputCode == )
        }
    }
}

public enum ConsoleState { MAIN_MENU, CREATE_FOOD, EDIT_FOOD, DELETE_FOOD, EXIT };
public enum Trigger { ACTION_CREATE, BUKA_PINTU };

public class ConsoleStateMachine
{
    public ConsoleState currentState = ConsoleState.MAIN_MENU;

    public class Transition
    {
        public ConsoleState currentState;
        public ConsoleState previousState;
        public Trigger trigger;

        public Transition(ConsoleState initialState, ConsoleState previousState, Trigger trigger)
        {
            this.currentState = initialState; 
            this.previousState = previousState;
            this.trigger = trigger;
        }
    }

    Transition[] transitions =
    {
            new Transition(ConsoleState.MAIN_MENU, ConsoleState.CREATE_FOOD, Trigger.ACTION_CREATE),
    };

    public ConsoleState GetNextState(ConsoleState state, Trigger trigger)
    {
        ConsoleState previousState = state;

        for (int i = 0; i < transitions.Length; i++)
        {
            Transition transition = transitions[i];

            if (state == transition.currentState && trigger == transition.trigger)
            {
                previousState = transition.previousState;
            }
        }

        return previousState;
    }

    public void ActivateTrigger(Trigger trigger)
    {
        Console.WriteLine("Hello World");
    }
}