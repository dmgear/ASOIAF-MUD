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

        // -------------------------
        // Region
        // -------------------------

        Console.WriteLine();
        Console.WriteLine("Choose your region:");

        Regions[] regions = Enum.GetValues<Regions>();

        for (int i = 0; i < regions.Length; i++)
        {
            Region region = Region.GetRegionInformation(regions[i]);

            Console.WriteLine($"{i + 1}. {region.Name}");
        }

        int regionChoice = int.Parse(Console.ReadLine() ?? "1") - 1;
        Regions selectedRegion = regions[regionChoice];

        background.Region = Region.GetRegionInformation(selectedRegion);


        // -------------------------
        // Noble House
        // -------------------------

        Console.WriteLine();
        Console.WriteLine("Do you belong to a noble house?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");

        int nobleChoice = int.Parse(Console.ReadLine() ?? "2");

        if (nobleChoice == 1)
        {
            List<House> houses =
                House.HouseFilters.GetHousesByRegion(selectedRegion);

            Console.WriteLine();
            Console.WriteLine("Choose your house:");

            for (int i = 0; i < houses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {houses[i].Name}");
            }

            int houseChoice = int.Parse(Console.ReadLine() ?? "1") - 1;

            background.House =
                Enum.Parse<HouseName>(houses[houseChoice].Name);
        }
        else
        {
            background.House = null;
        }


        // -------------------------
        // Bastard
        // -------------------------

        Console.WriteLine();
        Console.WriteLine("Are you a bastard?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");

        int bastardChoice = int.Parse(Console.ReadLine() ?? "2");

        background.IsBastard = bastardChoice == 1;


        // -------------------------
        // Surname
        // -------------------------

        if (background.IsBastard)
        {
            // Bastards use the surname associated
            // with their region.
            player.Surname =
                Region.GetRegionInformation(selectedRegion).BastardSurname ?? "";
        }
        else if (background.House.HasValue)
        {
            // Legitimate member of a noble house.
            player.Surname =
                House.GetHouseInformation(background.House.Value).Surname;
        }
        else
        {
            // Commoner with no noble house.
            player.Surname = "";
        }

        player.Background = background;
    }
}