using TheLongNight.Commands;

namespace TheLongNight.Commands;

public class CommandHandler
{
    private readonly GameCommands _commands;

    public CommandHandler(GameCommands commands)
    {
        _commands = commands;
    }

    public bool Handle(string input)
    {
        string command =
            input.Trim().ToLower();

        if (command == "")
        {
            return true;
        }

        switch (command)
        {
            case "look":
                _commands.Look();
                break;

            case "exits":
                _commands.DisplayExits();
                break;

            case "character":
                _commands.DisplayCharacter();
                break;

            case "help":
                _commands.Help();
                break;

            case "quit":
                Console.WriteLine("Goodbye.");
                return false;

            default:

                if (command.StartsWith("move "))
                {
                    string direction =
                        command.Substring(5).Trim();

                    HandleMove(direction);
                }
                else
                {
                    Console.WriteLine(
                        "Command not recognized."
                    );
                }

                break;
        }

        return true;
    }

    private void HandleMove(string direction)
    {
        switch (direction)
        {
            case "north":
            case "south":
            case "east":
            case "west":
            case "up":
            case "down":
                _commands.Move(direction);
                break;

            default:
                Console.WriteLine(
                    $"'{direction}' is not a valid direction."
                );
                break;
        }
    }
}