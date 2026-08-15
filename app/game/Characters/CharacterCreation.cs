namespace TheLongNight.Characters;

public class CharacterCreator
{
    public Player CreateCharacter()
    {
        Player player = new Player();

        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("       CHARACTER CREATION");
        Console.WriteLine("=================================");
        Console.WriteLine();

        SetName(player);
        SetBackground(player);

        return player;
    }

    private void SetName(Player player)
    {
        Console.Write("Enter your name: ");
        player.Name = Console.ReadLine() ?? "";
    }

    private void SetBackground(Player player)
    {
        Background background = new Background();

        Console.WriteLine();
        Console.WriteLine("Choose your region:");

        Region[] regions = Enum.GetValues<Region>();

        for (int i = 0; i < regions.Length; i++)
        {
            RegionData region = Regions.Get(regions[i]);

            Console.WriteLine($"{i + 1}. {region.Name}");
        }

        int regionChoice = GetChoice(regions.Length);
        background.Region = regions[regionChoice - 1];

        Console.WriteLine();
        Console.WriteLine("Do you belong to a noble house?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");

        int nobleChoice = GetChoice(2);

        if (nobleChoice == 1)
        {
            HouseName[] houses = Enum.GetValues<HouseName>();

            Console.WriteLine();
            Console.WriteLine("Choose your house:");

            for (int i = 0; i < houses.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {houses[i]}");
            }

            int houseChoice = GetChoice(houses.Length);

            background.House = houses[houseChoice - 1];
        }
        else
        {
            background.House = null;
        }

        Console.WriteLine();
        Console.WriteLine("Are you a bastard?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");

        int bastardChoice = GetChoice(2);

        background.IsBastard = bastardChoice == 1;

        if (background.IsBastard)
        {
            string surname = Regions.Get(background.Region).BastardSurname;
        }
        else if (background.House.HasValue)
        {
            string.surname = Regions.Get(background.Region).NobleSurname;
        }
        else 
        {
            surname ="";
        }

        player.Background = background;
    }
}