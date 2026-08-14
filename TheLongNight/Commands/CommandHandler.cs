namespace TheLongNight.Commands;

public static class CommandHandler
{
    public static bool Handle(string input)
    {
        string command = input.Trim().ToLower();

        switch (command)
        {
            case "look":
                Look();
                break;

            case "help":
                Help();
                break;

            case "quit":
                Console.WriteLine("Goodbye.");
                return false;

            default:
                Console.WriteLine("Command not recognized.");
                break;
        }

        return true;
    }

    private static void Look()
    {
        Console.WriteLine();
        Console.WriteLine("Castle Black stands before you.");
        Console.WriteLine("The Wall rises impossibly high above.");
        Console.WriteLine("Black-clad men move through the yard.");
        Console.WriteLine();
    }

    private static void Help()
    {
        Console.WriteLine();
        Console.WriteLine("Available commands:");
        Console.WriteLine("  look");
        Console.WriteLine("  help");
        Console.WriteLine("  quit");
        Console.WriteLine();
    }

    internal static void PrintCastleBlack()
    {
        Console.WriteLine("""
Castle Black


   /\                       /\                         /\
  /  \                     /  \                       /  \
 /____\                   /____\                     /____\
 | [] |                   | [] |                     | [] |
 |    |        /\         |    |         /\          |    |
 |    |       /  \        |    |        /  \         |    |
 |    |      |    |       |    |       |    |        |    |
 |    |      |    |       |    |       |    |        |    |
 |____|______|____|_______|____|_______|____|________|____|
    ||           ||            ||           ||           ||
    ||           ||            ||           ||           ||
____||___________||____________||___________||____________||____
/
________________________________________________________________
""");
    }
}