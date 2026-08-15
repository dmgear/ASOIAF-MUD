using TheLongNight.Accounts;
using TheLongNight.Characters;

namespace TheLongNight;

public class Game
{
    public async Task Start()
    {
        Console.Title = "The Long Night";

        AccountRepository repository = new AccountRepository();
        AuthenticationService authentication =
            new AuthenticationService(repository);

        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("          THE LONG NIGHT");
        Console.WriteLine("=================================");
        Console.WriteLine();

        Console.WriteLine("1. Login");
        Console.WriteLine("2. Create Account");
        Console.WriteLine();

        Console.Write("Choice: ");

        string choice = Console.ReadLine() ?? "";

        Account? account = choice switch
        {
            "1" => authentication.Login(),
            "2" => authentication.Register(),
            _ => null
        };

        if (account == null)
        {
            Console.WriteLine("Unable to authenticate.");
            return;
        }

        // Player is authenticated at this point.

        CharacterCreator characterCreator = new CharacterCreator();

        Player player = characterCreator.CreateCharacter();

        Console.WriteLine();
        Console.WriteLine(
            $"Welcome to the Night's Watch, {player.Name} {player.Surname}."
        );

        // Eventually:
        //
        // await commandHandler.StartAsync();
    }
}