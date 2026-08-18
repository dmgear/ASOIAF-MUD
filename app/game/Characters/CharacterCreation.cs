namespace TheLongNight.Characters;

public class CharacterCreator
{
    public PlayerCharacter CreateCharacter()
    {
        PlayerCharacter player = new PlayerCharacter();

        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("       CHARACTER CREATION");
        Console.WriteLine("=================================");
        Console.WriteLine();

        SetName(player);
        SetBackground(player);

        return player;
    }

    private void SetName(PlayerCharacter player)
    {
        Console.Write("Enter your name: ");

        player.Name = Console.ReadLine() ?? "";
    }

    private void SetBackground(PlayerCharacter player)
    {
        Background background = new Background();

        // -------------------------
        // Region
        // -------------------------

        Console.WriteLine();
        Console.WriteLine("Choose your region:");
        Console.WriteLine();

        Regions[] regions = Enum.GetValues<Regions>();

        for (int i = 0; i < regions.Length; i++)
        {
            Region region =
                Region.GetRegionInformation(regions[i]);

            Console.WriteLine($"{i + 1}. {region.Name}");
        }

        Console.WriteLine();
        Console.Write("Region: ");

        if (!int.TryParse(
                Console.ReadLine(),
                out int regionChoice) ||
            regionChoice < 1 ||
            regionChoice > regions.Length)
        {
            Console.WriteLine("Invalid region.");
            return;
        }

        Regions selectedRegion =
            regions[regionChoice - 1];

        background.Region =
            Region.GetRegionInformation(selectedRegion);


        // -------------------------
        // Noble House
        // -------------------------

        Console.WriteLine();
        Console.WriteLine("Do you belong to a noble house?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        Console.WriteLine();

        Console.Write("Choice: ");

        if (!int.TryParse(
                Console.ReadLine(),
                out int nobleChoice))
        {
            nobleChoice = 2;
        }

        if (nobleChoice == 1)
        {
            List<House> houses =
                House.HouseFilters.GetHousesByRegion(selectedRegion);

            if (houses.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "There are no noble houses available in this region."
                );

                background.House = null;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Choose your house:");
                Console.WriteLine();

                for (int i = 0; i < houses.Count; i++)
                {
                    Console.WriteLine(
                        $"{i + 1}. {houses[i].Name}"
                    );
                }

                Console.WriteLine();
                Console.Write("House: ");

                if (!int.TryParse(
                        Console.ReadLine(),
                        out int houseChoice) ||
                    houseChoice < 1 ||
                    houseChoice > houses.Count)
                {
                    Console.WriteLine("Invalid house.");

                    background.House = null;
                }
                else
                {
                    House selectedHouse =
                        houses[houseChoice - 1];

                    if (Enum.TryParse<HouseName>(
                            selectedHouse.Name,
                            out HouseName houseName))
                    {
                        background.House = houseName;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(
                            "Unable to determine the selected house."
                        );

                        background.House = null;
                    }
                }
            }
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
        Console.WriteLine();

        Console.Write("Choice: ");

        if (!int.TryParse(
                Console.ReadLine(),
                out int bastardChoice))
        {
            bastardChoice = 2;
        }

        background.IsBastard =
            bastardChoice == 1;


        // -------------------------
        // Surname
        // -------------------------

        if (background.IsBastard)
        {
            // Bastards use the surname associated
            // with their region.

            player.Surname =
                Region.GetRegionInformation(selectedRegion)
                    .BastardSurname ?? "";
        }
        else if (background.House.HasValue)
        {
            // Legitimate member of a noble house.

            player.Surname =
                House.GetHouseInformation(
                    background.House.Value
                ).Surname;
        }
        else
        {
            // Commoner with no noble house.

            player.Surname = "";
        }


        // -------------------------
        // Save Background
        // -------------------------

        player.Background = background;
    }
}