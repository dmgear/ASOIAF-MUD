namespace TheLongNight.Characters;

public enum Regions
{
    North,
    Vale,
    Riverlands,
    Westerlands,
    Crownlands,
    Reach,
    Stormlands,
    Dorne,
    IronIslands
}

public class Region
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string BastardSurname { get; set; } = "";

    public static Region GetRegionInformation(Regions region)
{
    return region switch
    {
        Regions.North => new Region
        {
            Name = "The North",
            Description = "The North is a vast and cold region, home to the Stark family and their bannermen.",
            BastardSurname = "Snow"
        },

        Regions.Vale => new Region
        {
            Name = "The Vale",
            Description = "The Vale is a mountainous region, known for its impregnable castles and the Eyrie.",
            BastardSurname = "Stone"
        },

        Regions.Riverlands => new Region
        {
            Name = "The Riverlands",
            Description = "The Riverlands are a fertile region, crisscrossed by rivers and home to many noble houses.",
            BastardSurname = "Rivers"
        },

        Regions.Westerlands => new Region
        {
            Name = "The Westerlands",
            Description = "The Westerlands are rich in gold mines, ruled by House Lannister from Casterly Rock.",
            BastardSurname = "Hill"
        },

        Regions.Crownlands => new Region
        {
            Name = "The Crownlands",
            Description = "The Crownlands surround the capital city of King's Landing, ruled directly by the Iron Throne.",
            BastardSurname = "Waters"
        },

        Regions.Reach => new Region
        {
            Name = "The Reach",
            Description = "The Reach is a fertile and populous region, known for its chivalry and the Tyrell family.",
            BastardSurname = "Flowers"
        },

        Regions.Stormlands => new Region
        {
            Name = "The Stormlands",
            Description = "The Stormlands are a rugged coastal region, ruled by House Baratheon from Storm's End.",
            BastardSurname = "Storm"
        },

        Regions.Dorne => new Region
        {
            Name = "Dorne",
            Description = "Dorne is a hot and arid region, known for its distinct culture and the Martell family.",
            BastardSurname = "Sand"
        },

        Regions.IronIslands => new Region
        {
            Name = "The Iron Islands",
            Description = "The Iron Islands are a harsh and rocky archipelago, home to the seafaring Ironborn.",
            BastardSurname = "Pyke"
        },

        _ => throw new ArgumentException("Unknown region.")
    };
}
}