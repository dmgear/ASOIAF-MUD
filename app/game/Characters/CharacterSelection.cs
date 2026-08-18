using TheLongNight.Accounts;

namespace TheLongNight.Characters;

public class CharacterSelectionService
{
    private readonly CharacterCreator _characterCreator;
    private readonly AccountRepository _repository;

    public CharacterSelectionService(CharacterCreator characterCreator, AccountRepository repository)
    {
        _characterCreator = characterCreator;
        _repository = repository;
    }

    public PlayerCharacter? SelectCharacter(Account account)
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("       CHARACTER SELECTION");
        Console.WriteLine("=================================");
        Console.WriteLine();

        // -------------------------
        // No characters
        // -------------------------

        if (account.Characters.Count == 0)
        {
            Console.WriteLine("You do not have any characters.");
            Console.WriteLine();
            Console.WriteLine("1. Create Character");
            Console.WriteLine("2. Logout");
            Console.WriteLine();

            Console.Write("Choice: ");

            string menuChoice = Console.ReadLine() ?? "";

            if (menuChoice == "1")
            {
                return CreateCharacter(account);
            }

            return null;
        }


        // -------------------------
        // Existing characters
        // -------------------------

        Console.WriteLine("Your characters:");
        Console.WriteLine();

        for (int i = 0; i < account.Characters.Count; i++)
        {
            PlayerCharacter character = account.Characters[i];

            Console.WriteLine(
                $"{i + 1}. {character.Name} {character.Surname}"
            );
        }


        // -------------------------
        // Options
        // -------------------------

        Console.WriteLine();

        Console.WriteLine(
            $"{account.Characters.Count + 1}. Create Character"
        );

        Console.WriteLine(
            $"{account.Characters.Count + 2}. Logout"
        );

        Console.WriteLine();

        Console.Write("Choose a character: ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid choice.");
            return null;
        }


        // -------------------------
        // Existing character
        // -------------------------

        if (choice >= 1 && choice <= account.Characters.Count)
        {
            return account.Characters[choice - 1];
        }


        // -------------------------
        // Create character
        // -------------------------

        if (choice == account.Characters.Count + 1)
        {
            return CreateCharacter(account);
        }


        // -------------------------
        // Logout
        // -------------------------

        if (choice == account.Characters.Count + 2)
        {
            return null;
        }


        // -------------------------
        // Invalid choice
        // -------------------------

        Console.WriteLine("Invalid choice.");

        return null;
    }


    private PlayerCharacter CreateCharacter(Account account)
    {
        PlayerCharacter player = _characterCreator.CreateCharacter();

        account.Characters.Add(player);

        _repository.UpdateAccount(account);

        return player;
    }
}