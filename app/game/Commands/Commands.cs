using TheLongNight.Characters;
using TheLongNight.World;

namespace TheLongNight.Commands;

public class GameCommands
{
    private readonly PlayerCharacter _player;
    private readonly WorldManager _world;

    public GameCommands(PlayerCharacter player, WorldManager world)
    {
        _player = player;
        _world = world;
    }

    public void Look()
    {
        Location? location =
            _world.GetLocation(_player.Location);

        if (location == null)
        {
            Console.WriteLine("You are nowhere.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine(location.Name);
        Console.WriteLine();
        Console.WriteLine(location.Description);
        Console.WriteLine();

        DisplayExits();
    }

    public void DisplayExits()
    {
        Location? location =
            _world.GetLocation(_player.Location);

        if (location == null)
        {
            Console.WriteLine("You are nowhere.");
            return;
        }

        if (location.Exits.Count == 0)
        {
            Console.WriteLine("There are no obvious exits.");
            return;
        }

        Console.WriteLine("Exits:");

        foreach (string direction in location.Exits.Keys)
        {
            Console.WriteLine($"  {direction}");
        }

        Console.WriteLine();
    }

    public void Move(string direction)
    {
        Location? currentLocation =
            _world.GetLocation(_player.Location);

        if (currentLocation == null)
        {
            Console.WriteLine("You are nowhere.");
            return;
        }

        Location? destination =
            _world.GetExit(currentLocation, direction);

        if (destination == null)
        {
            Console.WriteLine(
                $"You cannot go {direction} from here."
            );

            return;
        }

        _player.Location = destination.Id;

        Console.WriteLine();
        Console.WriteLine($"You move {direction}.");
        Console.WriteLine();

        Look();
    }

    public void DisplayCharacter()
    {
        Console.WriteLine();
        Console.WriteLine(
            $"Name:     {_player.Name} {_player.Surname}"
        );
        Console.WriteLine($"Level:    {_player.Level}");
        Console.WriteLine(
            $"Health:   {_player.Health}/{_player.MaxHealth}"
        );
        Console.WriteLine($"Gold:     {_player.Gold}");

        Location? location =
            _world.GetLocation(_player.Location);

        Console.WriteLine(
            $"Location: {location?.Name ?? "Unknown"}"
        );

        Console.WriteLine();
    }

    public void Help()
    {
        Console.WriteLine();
        Console.WriteLine("Available commands:");
        Console.WriteLine("  look");
        Console.WriteLine("  exits");
        Console.WriteLine("  move <direction, i.e., north, south, east, west, up, down>");
        Console.WriteLine("  character");
        Console.WriteLine("  help");
        Console.WriteLine("  quit");
        Console.WriteLine();
    }
}