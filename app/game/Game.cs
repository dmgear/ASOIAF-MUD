using TheLongNight.Accounts;
using TheLongNight.Characters;
using TheLongNight.Commands;
using TheLongNight.World;

namespace TheLongNight;

public class Game
{
    public async Task Start()
    {
        Console.Title = "The Long Night";

        try
        {
            // -------------------------
            // Authentication
            // -------------------------

            AccountRepository repository =
                new AccountRepository();

            AuthenticationService authentication =
                new AuthenticationService(repository);

            AccountMenu accountMenu =
                new AccountMenu(authentication);

            Account? account =
                accountMenu.Show();

            if (account == null)
            {
                Console.WriteLine("Unable to authenticate.");
                return;
            }


            // -------------------------
            // Character Selection
            // -------------------------

            CharacterCreator characterCreator =
                new CharacterCreator();

            CharacterSelectionService characterSelection =
                new CharacterSelectionService(
                    characterCreator,
                    repository
                );

            PlayerCharacter? player =
                characterSelection.SelectCharacter(account);

            if (player == null)
            {
                Console.WriteLine("No character selected.");
                return;
            }


            // -------------------------
            // Load World
            // -------------------------

            WorldManager world =
                new WorldManager();

            string worldPath =
                Path.Combine(
                    AppContext.BaseDirectory,
                    "game",
                    "World",
                    "world.json"
                );

            world.Load(worldPath);


            // -------------------------
            // Set Starting Location
            // -------------------------

            if (string.IsNullOrEmpty(player.Location))
            {
                if (world.StartingLocation == null)
                {
                    Console.WriteLine(
                        "Unable to determine starting location."
                    );

                    return;
                }

                player.Location =
                    world.StartingLocation.Id;
            }


            // -------------------------
            // Enter Game
            // -------------------------

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine(
                $"Welcome to the Night's Watch, " +
                $"{player.Name} {player.Surname}."
            );

            Console.WriteLine();


            // -------------------------
            // Initialize Commands
            // -------------------------

            GameCommands commands =
                new GameCommands(
                    player,
                    world
                );

            CommandHandler commandHandler =
                new CommandHandler(commands);


            // -------------------------
            // Display Starting Location
            // -------------------------

            commands.Look();


            // -------------------------
            // Command Loop
            // -------------------------

            while (true)
            {
                Console.Write("> ");

                string input =
                    await Console.In.ReadLineAsync() ?? "";

                bool shouldContinue =
                    commandHandler.Handle(input);

                if (!shouldContinue)
                {
                    break;
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("          GAME ERROR");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Console.WriteLine(exception);

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit.");

            Console.ReadLine();
        }
    }
}