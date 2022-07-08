// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        //also might want to idiot proof this later on
        //might want to consider making all this code within main it's own method
        //Console.WriteLine("Welcome " + fullName);
        Console.WriteLine("What would you like to do");
        Console.WriteLine("1: Clock-in or Clock-out");
        Console.WriteLine("2: Take time off work");
        Console.WriteLine("3: Change account settings");
        Console.WriteLine("4: Exit");
        string WhatToDo = Console.ReadLine();
        bool OptionTurnedOn = true;
        while (OptionTurnedOn == true) {
            switch (WhatToDo)
            {
                case "1":
                    Console.WriteLine("hello clock");
                    break;
                case "2":
                    Console.WriteLine("hello timeoff");
                    break;
                case "3":
                    Console.WriteLine("hello account");
                    break;
                default:
                    OptionTurnedOn = false;
                    break;
            }
            Console.WriteLine("What would you like to do");
            Console.WriteLine("1: Clock-in or Clock-out");
            Console.WriteLine("2: Take time off work");
            Console.WriteLine("3: Change account settings");
            Console.WriteLine("4: Exit");
            WhatToDo = Console.ReadLine();
        }
    }
}