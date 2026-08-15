namespace TheLongNight.Characters;

public enum HouseName
{
    // North
    Stark,
    Bolton,
    Umber,
    Karstark,
    Manderly,
    Mormont,
    Reed,
    Glover,
    Dustin,
    Ryswell,
    Cerwyn,
    Tallhart,
    Hornwood,
    Flint,
    Locke,
    Slate,
    Wull,
    Norrey,
    Liddle,
    Magnar,
    // Vale
    Arryn,
    Royce,
    Waynwood,
    Corbray,
    Hunter,
    Redfort,
    Templeton,
    Belmore,
    Grafton,
    Sunderland,
    Coldwater,
    Lynderly,
    Tollett,
    // Riverlands
    Tully,
    Blackwood,
    Bracken,
    Mallister,
    Frey,
    Mooton,
    Piper,
    Vance,
    Whent,
    Darry,
    Ryger,
    Smallwood,
    Charlton,
    Haigh,
    Hawick,
    // Westerlands
    Lannister,
    Casterly,
    Marbrand,
    Crakehall,
    Lefford,
    Lydden,
    Brax,
    Serrett,
    Swyft,
    Farman,
    Westerling,
    Prester,
    Reyne,
    Tarbeck,
    Payne,
    Banefort,
    // Reach
    Gardener,
    Hightower,
    Rowan,
    Oakheart,
    Redwyne,
    Florent,
    Tarly,
    Tyrell,
    Beesbury,
    Caswell,
    Crane,
    Fossoway,
    Merryweather,
    Peake,
    Ashford,
    Bulwer,
    Costayne,
    Graceford,
    Meadows,
    // Stormlands
    Baratheon,
    Durrandon,
    Tarth,
    Estermont,
    Caron,
    Swann,
    Morrigen,
    Connington,
    Selmy,
    Wylde,
    Fell,
    Buckler,
    Penrose,
    Trant,
    // Iron Islands
    Greyjoy,
    Greyiron,
    Drumm,
    Harlaw,
    Blacktyde,
    Goodbrother,
    Farwynd,
    Botley,
    Merlyn,
    Saltcliffe,
    Stonehouse,
    // Dorne
    Dayne,
    Yronwood,
    Fowler,
    Uller,
    Manwoody,
    Allyrion,
    Jordayne,
    Toland,
    Qorgyle,
    Vaith,
    Wyl,
    // Crownlands / Other
    
    Massey,
    Darklyn,
    Rosby,
    Stokeworth,
    Rykker,
    Bar_Emmon,
    Brune,
    Buckwell,
    Hollard,
    Sunglass,

    //Dorne

    Martell
}

public class House
{
    public string Name { get; set; } = "";
    public string Motto { get; set; } = "";
    public string Description { get; set; } = "";
    public string Seat { get; set; } = "";
    public Regions Region { get; set; } = Regions.North;
    public string Surname { get; set; } = "";

    public static House GetHouseInformation(HouseName houseName)
{
    return houseName switch
    {
        HouseName.Stark => new House
        {
            Name = "Stark",
            Description = "An ancient and powerful house of the North, ruling from Winterfell.",
            Seat = "Winterfell",
            Region = Regions.North,
            Surname = "Stark"
        },

        HouseName.Arryn => new House
        {
            Name = "Arryn",
            Description = "An ancient house of the Vale, ruling from the Eyrie.",
            Seat = "The Eyrie",
            Region = Regions.Vale,
            Surname = "Arryn"
        },

        HouseName.Tully => new House
        {
            Name = "Tully",
            Description = "The ruling house of the Riverlands, based at Riverrun.",
            Seat = "Riverrun",
            Region = Regions.Riverlands,
            Surname = "Tully"
        },

        HouseName.Lannister => new House
        {
            Name = "Lannister",
            Description = "One of the wealthiest and most powerful houses in Westeros, ruling from Casterly Rock.",
            Seat = "Casterly Rock",
            Region = Regions.Westerlands,
            Surname = "Lannister"
        },

        HouseName.Baratheon => new House
        {
            Name = "Baratheon",
            Description = "A powerful house of the Stormlands, ruling from Storm's End.",
            Seat = "Storm's End",
            Region = Regions.Stormlands,
            Surname = "Baratheon"
        },

        HouseName.Tyrell => new House
        {
            Name = "Tyrell",
            Description = "The ruling house of the Reach, based at Highgarden.",
            Seat = "Highgarden",
            Region = Regions.Reach,
            Surname = "Tyrell"
        },

        HouseName.Martell => new House
        {
            Name = "Martell",
            Description = "The ruling house of Dorne, based at Sunspear.",
            Seat = "Sunspear",
            Region = Regions.Dorne,
            Surname = "Martell"
        },

        HouseName.Greyjoy => new House
        {
            Name = "Greyjoy",
            Description = "The ruling house of the Iron Islands, based at Pyke.",
            Seat = "Pyke",
            Region = Regions.IronIslands,
            Surname = "Greyjoy"
        },

        _ => throw new ArgumentException("Unknown house.")
    };
}


    public static class HouseFilters
    {
        public static List<House> GetHousesByRegion(Regions region)
        {
            return Enum.GetValues<HouseName>()
                .Select(House.GetHouseInformation)
                .Where(h => h.Region == region)
                .ToList();
        }
    }
}