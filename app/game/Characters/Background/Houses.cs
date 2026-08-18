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
        // =====================================================
        // NORTH
        // =====================================================

        HouseName.Stark => new House
        {
            Name = "Stark",
            Motto = "Winter Is Coming",
            Description = "The ancient ruling house of the North, descended from the Kings of Winter and seated at Winterfell.",
            Seat = "Winterfell",
            Region = Regions.North,
            Surname = "Stark"
        },

        HouseName.Bolton => new House
        {
            Name = "Bolton",
            Motto = "Our Blades Are Sharp",
            Description = "An ancient and formidable house of the North, infamous for its history of flaying enemies.",
            Seat = "The Dreadfort",
            Region = Regions.North,
            Surname = "Bolton"
        },

        HouseName.Umber => new House
        {
            Name = "Umber",
            Motto = "Last Hearth",
            Description = "A powerful northern house known for its fierce warriors and loyalty to Winterfell.",
            Seat = "Last Hearth",
            Region = Regions.North,
            Surname = "Umber"
        },

        HouseName.Karstark => new House
        {
            Name = "Karstark",
            Motto = "The Sun of Winter",
            Description = "A northern house descended from House Stark, ruling lands east of Winterfell.",
            Seat = "Karhold",
            Region = Regions.North,
            Surname = "Karstark"
        },

        HouseName.Manderly => new House
        {
            Name = "Manderly",
            Motto = "No Known Motto",
            Description = "A wealthy and powerful northern house of southern origin, ruling from the port city of White Harbor.",
            Seat = "White Harbor",
            Region = Regions.North,
            Surname = "Manderly"
        },

        HouseName.Mormont => new House
        {
            Name = "Mormont",
            Motto = "Here We Stand",
            Description = "A hardy northern house ruling the remote and rugged Bear Island.",
            Seat = "Bear Island",
            Region = Regions.North,
            Surname = "Mormont"
        },

        HouseName.Reed => new House
        {
            Name = "Reed",
            Motto = "No Known Motto",
            Description = "The ancient crannogman house ruling the swamps of the Neck.",
            Seat = "Greywater Watch",
            Region = Regions.North,
            Surname = "Reed"
        },

        HouseName.Glover => new House
        {
            Name = "Glover",
            Motto = "No Known Motto",
            Description = "An ancient northern house and loyal bannerman of House Stark.",
            Seat = "Deepwood Motte",
            Region = Regions.North,
            Surname = "Glover"
        },

        HouseName.Dustin => new House
        {
            Name = "Dustin",
            Motto = "No Known Motto",
            Description = "An ancient northern house holding extensive lands in the barrowlands.",
            Seat = "Barrow Hall",
            Region = Regions.North,
            Surname = "Dustin"
        },

        HouseName.Ryswell => new House
        {
            Name = "Ryswell",
            Motto = "No Known Motto",
            Description = "A powerful northern house controlling much of the western barrowlands.",
            Seat = "The Rills",
            Region = Regions.North,
            Surname = "Ryswell"
        },

        HouseName.Cerwyn => new House
        {
            Name = "Cerwyn",
            Motto = "No Known Motto",
            Description = "A loyal northern house whose lands lie close to Winterfell.",
            Seat = "Castle Cerwyn",
            Region = Regions.North,
            Surname = "Cerwyn"
        },

        HouseName.Tallhart => new House
        {
            Name = "Tallhart",
            Motto = "No Known Motto",
            Description = "A northern house known for its warriors and loyalty to the Starks.",
            Seat = "Torrhen's Square",
            Region = Regions.North,
            Surname = "Tallhart"
        },

        HouseName.Hornwood => new House
        {
            Name = "Hornwood",
            Motto = "Righteous in Wrath",
            Description = "A northern house whose lands lie between Winterfell and the mountains of the North.",
            Seat = "Hornwood",
            Region = Regions.North,
            Surname = "Hornwood"
        },

        HouseName.Flint => new House
        {
            Name = "Flint",
            Motto = "No Known Motto",
            Description = "An ancient family with several branches spread throughout the northern mountains and highlands.",
            Seat = "Various",
            Region = Regions.North,
            Surname = "Flint"
        },

        HouseName.Locke => new House
        {
            Name = "Locke",
            Motto = "No Known Motto",
            Description = "A northern house sworn to Winterfell.",
            Seat = "Oldcastle",
            Region = Regions.North,
            Surname = "Locke"
        },

        HouseName.Slate => new House
        {
            Name = "Slate",
            Motto = "No Known Motto",
            Description = "A northern house sworn to House Stark.",
            Seat = "Blackpool",
            Region = Regions.North,
            Surname = "Slate"
        },

        HouseName.Wull => new House
        {
            Name = "Wull",
            Motto = "No Known Motto",
            Description = "A fierce mountain clan of the North, known for its hardy warriors.",
            Seat = "The Mountains of the North",
            Region = Regions.North,
            Surname = "Wull"
        },

        HouseName.Norrey => new House
        {
            Name = "Norrey",
            Motto = "No Known Motto",
            Description = "One of the mountain clans of the North, sworn to House Stark.",
            Seat = "The Northern Mountains",
            Region = Regions.North,
            Surname = "Norrey"
        },

        HouseName.Liddle => new House
        {
            Name = "Liddle",
            Motto = "No Known Motto",
            Description = "A mountain clan of the North dwelling among the northern highlands.",
            Seat = "The Northern Mountains",
            Region = Regions.North,
            Surname = "Liddle"
        },

        HouseName.Magnar => new House
        {
            Name = "Magnar",
            Motto = "No Known Motto",
            Description = "An ancient northern family associated with the remote island of Skagos.",
            Seat = "Kingshouse",
            Region = Regions.North,
            Surname = "Magnar"
        },


        // =====================================================
        // VALE
        // =====================================================

        HouseName.Arryn => new House
        {
            Name = "Arryn",
            Motto = "As High as Honor",
            Description = "The ancient ruling house of the Vale, claiming descent from the Andals' earliest kings.",
            Seat = "The Eyrie",
            Region = Regions.Vale,
            Surname = "Arryn"
        },

        HouseName.Royce => new House
        {
            Name = "Royce",
            Motto = "We Remember",
            Description = "An ancient and powerful house of the Vale with roots predating the arrival of the Andals.",
            Seat = "Runestone",
            Region = Regions.Vale,
            Surname = "Royce"
        },

        HouseName.Waynwood => new House
        {
            Name = "Waynwood",
            Motto = "No Known Motto",
            Description = "A powerful house of the Vale and one of House Arryn's principal bannermen.",
            Seat = "Ironoaks",
            Region = Regions.Vale,
            Surname = "Waynwood"
        },

        HouseName.Corbray => new House
        {
            Name = "Corbray",
            Motto = "No Known Motto",
            Description = "A proud and martial house of the Vale, famous for its ancestral Valyrian steel sword.",
            Seat = "Heart's Home",
            Region = Regions.Vale,
            Surname = "Corbray"
        },

        HouseName.Hunter => new House
        {
            Name = "Hunter",
            Motto = "No Known Motto",
            Description = "An ancient noble house of the Vale and bannerman of House Arryn.",
            Seat = "Longbow Hall",
            Region = Regions.Vale,
            Surname = "Hunter"
        },

        HouseName.Redfort => new House
        {
            Name = "Redfort",
            Motto = "No Known Motto",
            Description = "A powerful house of the Vale ruling from a massive red stone fortress.",
            Seat = "Redfort",
            Region = Regions.Vale,
            Surname = "Redfort"
        },

        HouseName.Templeton => new House
        {
            Name = "Templeton",
            Motto = "No Known Motto",
            Description = "A noble house of the Vale known for its knights.",
            Seat = "Ninestars",
            Region = Regions.Vale,
            Surname = "Templeton"
        },

        HouseName.Belmore => new House
        {
            Name = "Belmore",
            Motto = "No Known Motto",
            Description = "A noble house of the Vale sworn to House Arryn.",
            Seat = "Strongsong",
            Region = Regions.Vale,
            Surname = "Belmore"
        },

        HouseName.Grafton => new House
        {
            Name = "Grafton",
            Motto = "No Known Motto",
            Description = "A wealthy house controlling the important port of Gulltown.",
            Seat = "Gulltown",
            Region = Regions.Vale,
            Surname = "Grafton"
        },

        HouseName.Sunderland => new House
        {
            Name = "Sunderland",
            Motto = "No Known Motto",
            Description = "A noble house ruling the Three Sisters in the northern waters of the Vale.",
            Seat = "Sweetsister",
            Region = Regions.Vale,
            Surname = "Sunderland"
        },

        HouseName.Coldwater => new House
        {
            Name = "Coldwater",
            Motto = "No Known Motto",
            Description = "A noble house of the Vale sworn to House Arryn.",
            Seat = "Coldwater Burn",
            Region = Regions.Vale,
            Surname = "Coldwater"
        },

        HouseName.Lynderly => new House
        {
            Name = "Lynderly",
            Motto = "No Known Motto",
            Description = "A noble house of the Vale sworn to House Arryn.",
            Seat = "Snakewood",
            Region = Regions.Vale,
            Surname = "Lynderly"
        },

        HouseName.Tollett => new House
        {
            Name = "Tollett",
            Motto = "No Known Motto",
            Description = "A noble house of the Vale sworn to House Arryn.",
            Seat = "The Grey Glen",
            Region = Regions.Vale,
            Surname = "Tollett"
        },


        // =====================================================
        // RIVERLANDS
        // =====================================================

        HouseName.Tully => new House
        {
            Name = "Tully",
            Motto = "Family, Duty, Honor",
            Description = "The ruling house of the Riverlands, seated at the great castle of Riverrun.",
            Seat = "Riverrun",
            Region = Regions.Riverlands,
            Surname = "Tully"
        },

        HouseName.Blackwood => new House
        {
            Name = "Blackwood",
            Motto = "No Known Motto",
            Description = "An ancient house of the Riverlands with First Men traditions and an old feud with House Bracken.",
            Seat = "Raventree Hall",
            Region = Regions.Riverlands,
            Surname = "Blackwood"
        },

        HouseName.Bracken => new House
        {
            Name = "Bracken",
            Motto = "No Known Motto",
            Description = "An ancient Riverlands house locked in a bitter feud with House Blackwood.",
            Seat = "Stone Hedge",
            Region = Regions.Riverlands,
            Surname = "Bracken"
        },

        HouseName.Mallister => new House
        {
            Name = "Mallister",
            Motto = "Above the Rest",
            Description = "A powerful coastal house of the Riverlands sworn to House Tully.",
            Seat = "Seagard",
            Region = Regions.Riverlands,
            Surname = "Mallister"
        },

        HouseName.Frey => new House
        {
            Name = "Frey",
            Motto = "We Stand Together",
            Description = "A wealthy house controlling the strategically vital crossing of the Green Fork.",
            Seat = "The Twins",
            Region = Regions.Riverlands,
            Surname = "Frey"
        },

        HouseName.Mooton => new House
        {
            Name = "Mooton",
            Motto = "No Known Motto",
            Description = "A noble house controlling a prosperous port on the Trident.",
            Seat = "Maidenpool",
            Region = Regions.Riverlands,
            Surname = "Mooton"
        },

        HouseName.Piper => new House
        {
            Name = "Piper",
            Motto = "No Known Motto",
            Description = "A Riverlands house sworn to House Tully.",
            Seat = "Pinkmaiden",
            Region = Regions.Riverlands,
            Surname = "Piper"
        },

        HouseName.Vance => new House
        {
            Name = "Vance",
            Motto = "No Known Motto",
            Description = "A powerful Riverlands family with several branches sworn to House Tully.",
            Seat = "Wayfarer's Rest",
            Region = Regions.Riverlands,
            Surname = "Vance"
        },

        HouseName.Whent => new House
        {
            Name = "Whent",
            Motto = "No Known Motto",
            Description = "A noble Riverlands house historically associated with the great castle of Harrenhal.",
            Seat = "Harrenhal",
            Region = Regions.Riverlands,
            Surname = "Whent"
        },

        HouseName.Darry => new House
        {
            Name = "Darry",
            Motto = "No Known Motto",
            Description = "An ancient Riverlands house known for its loyalty and martial tradition.",
            Seat = "Darry",
            Region = Regions.Riverlands,
            Surname = "Darry"
        },

        HouseName.Ryger => new House
        {
            Name = "Ryger",
            Motto = "No Known Motto",
            Description = "A Riverlands house sworn to House Tully.",
            Seat = "The Willow Wood",
            Region = Regions.Riverlands,
            Surname = "Ryger"
        },

        HouseName.Smallwood => new House
        {
            Name = "Smallwood",
            Motto = "No Known Motto",
            Description = "A minor but established noble house of the Riverlands.",
            Seat = "Acorn Hall",
            Region = Regions.Riverlands,
            Surname = "Smallwood"
        },

        HouseName.Charlton => new House
        {
            Name = "Charlton",
            Motto = "No Known Motto",
            Description = "A noble house of the Riverlands sworn to House Tully.",
            Seat = "The Charlton lands",
            Region = Regions.Riverlands,
            Surname = "Charlton"
        },

        HouseName.Haigh => new House
        {
            Name = "Haigh",
            Motto = "No Known Motto",
            Description = "A noble house of the Riverlands sworn to House Tully.",
            Seat = "The Haigh lands",
            Region = Regions.Riverlands,
            Surname = "Haigh"
        },

        HouseName.Hawick => new House
        {
            Name = "Hawick",
            Motto = "No Known Motto",
            Description = "A minor noble house of the Riverlands.",
            Seat = "The Hawick lands",
            Region = Regions.Riverlands,
            Surname = "Hawick"
        },


        // =====================================================
        // WESTERLANDS
        // =====================================================

        HouseName.Lannister => new House
        {
            Name = "Lannister",
            Motto = "Hear Me Roar!",
            Description = "One of the wealthiest and most powerful houses in Westeros, ruling the Westerlands from Casterly Rock.",
            Seat = "Casterly Rock",
            Region = Regions.Westerlands,
            Surname = "Lannister"
        },

        HouseName.Casterly => new House
        {
            Name = "Casterly",
            Motto = "No Known Motto",
            Description = "An ancient house whose legendary ancestors once held Casterly Rock.",
            Seat = "Casterly Rock",
            Region = Regions.Westerlands,
            Surname = "Casterly"
        },

        HouseName.Marbrand => new House
        {
            Name = "Marbrand",
            Motto = "Burning Bright",
            Description = "A powerful Westerlands house sworn to House Lannister.",
            Seat = "Ashemark",
            Region = Regions.Westerlands,
            Surname = "Marbrand"
        },

        HouseName.Crakehall => new House
        {
            Name = "Crakehall",
            Motto = "None So Fierce",
            Description = "A powerful and martial house of the Westerlands.",
            Seat = "Crakehall",
            Region = Regions.Westerlands,
            Surname = "Crakehall"
        },

        HouseName.Lefford => new House
        {
            Name = "Lefford",
            Motto = "This We'll Defend",
            Description = "A wealthy Westerlands house controlling the Golden Tooth.",
            Seat = "The Golden Tooth",
            Region = Regions.Westerlands,
            Surname = "Lefford"
        },

        HouseName.Lydden => new House
        {
            Name = "Lydden",
            Motto = "No Known Motto",
            Description = "A noble house of the Westerlands sworn to House Lannister.",
            Seat = "Deep Den",
            Region = Regions.Westerlands,
            Surname = "Lydden"
        },

        HouseName.Brax => new House
        {
            Name = "Brax",
            Motto = "No Known Motto",
            Description = "A noble Westerlands house sworn to House Lannister.",
            Seat = "Harridan Hill",
            Region = Regions.Westerlands,
            Surname = "Brax"
        },

        HouseName.Serrett => new House
        {
            Name = "Serrett",
            Motto = "No Known Motto",
            Description = "A noble house of the Westerlands.",
            Seat = "Silverhill",
            Region = Regions.Westerlands,
            Surname = "Serrett"
        },

        HouseName.Swyft => new House
        {
            Name = "Swyft",
            Motto = "Awake! Awake!",
            Description = "A noble house of the Westerlands sworn to House Lannister.",
            Seat = "Cornfield",
            Region = Regions.Westerlands,
            Surname = "Swyft"
        },

        HouseName.Farman => new House
        {
            Name = "Farman",
            Motto = "The Wind Our Steed",
            Description = "An ancient house of the Westerlands ruling the island of Fair Isle.",
            Seat = "Faircastle",
            Region = Regions.Westerlands,
            Surname = "Farman"
        },

        HouseName.Westerling => new House
        {
            Name = "Westerling",
            Motto = "Honor, Not Honors",
            Description = "An ancient but diminished house of the Westerlands.",
            Seat = "The Crag",
            Region = Regions.Westerlands,
            Surname = "Westerling"
        },

        HouseName.Prester => new House
        {
            Name = "Prester",
            Motto = "No Known Motto",
            Description = "A noble house of the Westerlands sworn to House Lannister.",
            Seat = "Feastfires",
            Region = Regions.Westerlands,
            Surname = "Prester"
        },

        HouseName.Reyne => new House
        {
            Name = "Reyne",
            Motto = "No Known Motto",
            Description = "A once immensely powerful house of the Westerlands, destroyed after rebelling against House Lannister.",
            Seat = "Castamere",
            Region = Regions.Westerlands,
            Surname = "Reyne"
        },

        HouseName.Tarbeck => new House
        {
            Name = "Tarbeck",
            Motto = "No Known Motto",
            Description = "A Westerlands house destroyed alongside House Reyne after rebelling against the Lannisters.",
            Seat = "Tarbeck Hall",
            Region = Regions.Westerlands,
            Surname = "Tarbeck"
        },

        HouseName.Payne => new House
        {
            Name = "Payne",
            Motto = "No Known Motto",
            Description = "A noble house of the Westerlands known for its fierce loyalty to House Lannister.",
            Seat = "The Payne lands",
            Region = Regions.Westerlands,
            Surname = "Payne"
        },

        HouseName.Banefort => new House
        {
            Name = "Banefort",
            Motto = "No Known Motto",
            Description = "A coastal house of the Westerlands ruling from an ancient fortress.",
            Seat = "The Banefort",
            Region = Regions.Westerlands,
            Surname = "Banefort"
        },


        // =====================================================
        // REACH
        // =====================================================

        HouseName.Gardener => new House
        {
            Name = "Gardener",
            Motto = "Growing Strong",
            Description = "The ancient royal house of the Reach before the Targaryen conquest.",
            Seat = "Highgarden",
            Region = Regions.Reach,
            Surname = "Gardener"
        },

        HouseName.Hightower => new House
        {
            Name = "Hightower",
            Motto = "We Light the Way",
            Description = "One of the oldest and wealthiest houses of the Reach, ruling from Oldtown.",
            Seat = "The Hightower",
            Region = Regions.Reach,
            Surname = "Hightower"
        },

        HouseName.Rowan => new House
        {
            Name = "Rowan",
            Motto = "No Known Motto",
            Description = "A powerful house of the Reach sworn to the ruling house of the region.",
            Seat = "Goldengrove",
            Region = Regions.Reach,
            Surname = "Rowan"
        },

        HouseName.Oakheart => new House
        {
            Name = "Oakheart",
            Motto = "Our Roots Go Deep",
            Description = "An ancient and respected house of the Reach.",
            Seat = "Old Oak",
            Region = Regions.Reach,
            Surname = "Oakheart"
        },

        HouseName.Redwyne => new House
        {
            Name = "Redwyne",
            Motto = "No Known Motto",
            Description = "A wealthy naval house controlling the Arbor and its famous vineyards.",
            Seat = "The Arbor",
            Region = Regions.Reach,
            Surname = "Redwyne"
        },

        HouseName.Florent => new House
        {
            Name = "Florent",
            Motto = "No Known Motto",
            Description = "An ancient house of the Reach with a claim through marriage to House Gardener.",
            Seat = "Brightwater Keep",
            Region = Regions.Reach,
            Surname = "Florent"
        },

        HouseName.Tarly => new House
        {
            Name = "Tarly",
            Motto = "First in Battle",
            Description = "A powerful martial house of the Reach, renowned for its warriors.",
            Seat = "Horn Hill",
            Region = Regions.Reach,
            Surname = "Tarly"
        },

        HouseName.Tyrell => new House
        {
            Name = "Tyrell",
            Motto = "Growing Strong",
            Description = "The ruling house of the Reach after the extinction of House Gardener.",
            Seat = "Highgarden",
            Region = Regions.Reach,
            Surname = "Tyrell"
        },

        HouseName.Beesbury => new House
        {
            Name = "Beesbury",
            Motto = "Beware Our Sting",
            Description = "A noble house of the Reach with a long association with Oldtown and the royal court.",
            Seat = "Honeyholt",
            Region = Regions.Reach,
            Surname = "Beesbury"
        },

        HouseName.Caswell => new House
        {
            Name = "Caswell",
            Motto = "No Known Motto",
            Description = "A noble house controlling a strategically important crossing in the Reach.",
            Seat = "Bitterbridge",
            Region = Regions.Reach,
            Surname = "Caswell"
        },

        HouseName.Crane => new House
        {
            Name = "Crane",
            Motto = "No Known Motto",
            Description = "A noble house of the Reach sworn to House Tyrell.",
            Seat = "Red Lake",
            Region = Regions.Reach,
            Surname = "Crane"
        },

        HouseName.Fossoway => new House
        {
            Name = "Fossoway",
            Motto = "A Taste of Glory",
            Description = "A wealthy Reach house with several branches and a history of rivalry.",
            Seat = "Cider Hall",
            Region = Regions.Reach,
            Surname = "Fossoway"
        },

        HouseName.Merryweather => new House
        {
            Name = "Merryweather",
            Motto = "No Known Motto",
            Description = "A noble house of the Reach.",
            Seat = "Longtable",
            Region = Regions.Reach,
            Surname = "Merryweather"
        },

        HouseName.Peake => new House
        {
            Name = "Peake",
            Motto = "No Known Motto",
            Description = "An ambitious Reach house with a long and often turbulent history.",
            Seat = "Starpike",
            Region = Regions.Reach,
            Surname = "Peake"
        },

        HouseName.Ashford => new House
        {
            Name = "Ashford",
            Motto = "No Known Motto",
            Description = "An ancient noble house of the Reach.",
            Seat = "Ashford",
            Region = Regions.Reach,
            Surname = "Ashford"
        },

        HouseName.Bulwer => new House
        {
            Name = "Bulwer",
            Motto = "No Known Motto",
            Description = "A noble house of the Reach sworn to House Tyrell.",
            Seat = "Blackcrown",
            Region = Regions.Reach,
            Surname = "Bulwer"
        },

        HouseName.Costayne => new House
        {
            Name = "Costayne",
            Motto = "No Known Motto",
            Description = "A noble house of the Reach.",
            Seat = "Three Towers",
            Region = Regions.Reach,
            Surname = "Costayne"
        },

        HouseName.Graceford => new House
        {
            Name = "Graceford",
            Motto = "No Known Motto",
            Description = "A noble house of the Reach.",
            Seat = "Holyhall",
            Region = Regions.Reach,
            Surname = "Graceford"
        },

        HouseName.Meadows => new House
        {
            Name = "Meadows",
            Motto = "No Known Motto",
            Description = "A noble house of the Reach.",
            Seat = "Grassy Vale",
            Region = Regions.Reach,
            Surname = "Meadows"
        },


        // =====================================================
        // STORMLANDS
        // =====================================================

        HouseName.Baratheon => new House
        {
            Name = "Baratheon",
            Motto = "Ours Is the Fury",
            Description = "A powerful house of the Stormlands descended from the legendary Durrandon kings.",
            Seat = "Storm's End",
            Region = Regions.Stormlands,
            Surname = "Baratheon"
        },

        HouseName.Durrandon => new House
        {
            Name = "Durrandon",
            Motto = "No Known Motto",
            Description = "The ancient royal house of the Stormlands before its extinction and replacement by House Baratheon.",
            Seat = "Storm's End",
            Region = Regions.Stormlands,
            Surname = "Durrandon"
        },

        HouseName.Tarth => new House
        {
            Name = "Tarth",
            Motto = "No Known Motto",
            Description = "A noble house ruling the island of Tarth in the Stormlands.",
            Seat = "Evenfall Hall",
            Region = Regions.Stormlands,
            Surname = "Tarth"
        },

        HouseName.Estermont => new House
        {
            Name = "Estermont",
            Motto = "No Known Motto",
            Description = "A noble house ruling the island of Estermont and sworn to House Baratheon.",
            Seat = "Greenstone",
            Region = Regions.Stormlands,
            Surname = "Estermont"
        },

        HouseName.Caron => new House
        {
            Name = "Caron",
            Motto = "No Known Motto",
            Description = "A powerful house of the Dornish Marches in the Stormlands.",
            Seat = "Nightsong",
            Region = Regions.Stormlands,
            Surname = "Caron"
        },

        HouseName.Swann => new House
        {
            Name = "Swann",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands ruling from Stonehelm.",
            Seat = "Stonehelm",
            Region = Regions.Stormlands,
            Surname = "Swann"
        },

        HouseName.Morrigen => new House
        {
            Name = "Morrigen",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands sworn to House Baratheon.",
            Seat = "Crow's Nest",
            Region = Regions.Stormlands,
            Surname = "Morrigen"
        },

        HouseName.Connington => new House
        {
            Name = "Connington",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands known for its fierce martial tradition.",
            Seat = "Griffin's Roost",
            Region = Regions.Stormlands,
            Surname = "Connington"
        },

        HouseName.Selmy => new House
        {
            Name = "Selmy",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands renowned for producing exceptional knights.",
            Seat = "Harvest Hall",
            Region = Regions.Stormlands,
            Surname = "Selmy"
        },

        HouseName.Wylde => new House
        {
            Name = "Wylde",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands sworn to House Baratheon.",
            Seat = "Rain House",
            Region = Regions.Stormlands,
            Surname = "Wylde"
        },

        HouseName.Fell => new House
        {
            Name = "Fell",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands.",
            Seat = "Felwood",
            Region = Regions.Stormlands,
            Surname = "Fell"
        },

        HouseName.Buckler => new House
        {
            Name = "Buckler",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands sworn to House Baratheon.",
            Seat = "The Water Gardens",
            Region = Regions.Stormlands,
            Surname = "Buckler"
        },

        HouseName.Penrose => new House
        {
            Name = "Penrose",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands.",
            Seat = "Parchments",
            Region = Regions.Stormlands,
            Surname = "Penrose"
        },

        HouseName.Trant => new House
        {
            Name = "Trant",
            Motto = "No Known Motto",
            Description = "A noble house of the Stormlands sworn to House Baratheon.",
            Seat = "Gallowsgrey",
            Region = Regions.Stormlands,
            Surname = "Trant"
        },


        // =====================================================
        // IRON ISLANDS
        // =====================================================

        HouseName.Greyjoy => new House
        {
            Name = "Greyjoy",
            Motto = "We Do Not Sow",
            Description = "The ruling house of the Iron Islands, descended from the ancient kings of the Ironborn.",
            Seat = "Pyke",
            Region = Regions.IronIslands,
            Surname = "Greyjoy"
        },

        HouseName.Greyiron => new House
        {
            Name = "Greyiron",
            Motto = "No Known Motto",
            Description = "An ancient house of the Iron Islands that once produced many kings of the Ironborn.",
            Seat = "Old Wyk",
            Region = Regions.IronIslands,
            Surname = "Greyiron"
        },

        HouseName.Drumm => new House
        {
            Name = "Drumm",
            Motto = "No Known Motto",
            Description = "A powerful Ironborn house known for its reaving traditions and ancient history.",
            Seat = "Old Wyk",
            Region = Regions.IronIslands,
            Surname = "Drumm"
        },

        HouseName.Harlaw => new House
        {
            Name = "Harlaw",
            Motto = "No Known Motto",
            Description = "One of the most powerful houses of the Iron Islands, ruling the island of Harlaw.",
            Seat = "Ten Towers",
            Region = Regions.IronIslands,
            Surname = "Harlaw"
        },

        HouseName.Blacktyde => new House
        {
            Name = "Blacktyde",
            Motto = "No Known Motto",
            Description = "A noble Ironborn house ruling lands on Great Wyk.",
            Seat = "Blacktyde",
            Region = Regions.IronIslands,
            Surname = "Blacktyde"
        },

        HouseName.Goodbrother => new House
        {
            Name = "Goodbrother",
            Motto = "No Known Motto",
            Description = "A powerful Ironborn house with several branches throughout the islands.",
            Seat = "Hammerhorn",
            Region = Regions.IronIslands,
            Surname = "Goodbrother"
        },

        HouseName.Farwynd => new House
        {
            Name = "Farwynd",
            Motto = "No Known Motto",
            Description = "A mysterious Ironborn family associated with the remote western islands.",
            Seat = "The Lonely Light",
            Region = Regions.IronIslands,
            Surname = "Farwynd"
        },

        HouseName.Botley => new House
        {
            Name = "Botley",
            Motto = "No Known Motto",
            Description = "A noble Ironborn house sworn to House Greyjoy.",
            Seat = "Lordsport",
            Region = Regions.IronIslands,
            Surname = "Botley"
        },

        HouseName.Merlyn => new House
        {
            Name = "Merlyn",
            Motto = "No Known Motto",
            Description = "A noble house of the Iron Islands.",
            Seat = "Pebbleton",
            Region = Regions.IronIslands,
            Surname = "Merlyn"
        },

        HouseName.Saltcliffe => new House
        {
            Name = "Saltcliffe",
            Motto = "No Known Motto",
            Description = "An Ironborn house ruling part of the island of Orkmont.",
            Seat = "Saltcliffe",
            Region = Regions.IronIslands,
            Surname = "Saltcliffe"
        },

        HouseName.Stonehouse => new House
        {
            Name = "Stonehouse",
            Motto = "No Known Motto",
            Description = "A noble Ironborn house sworn to House Greyjoy.",
            Seat = "The Iron Islands",
            Region = Regions.IronIslands,
            Surname = "Stonehouse"
        },


        // =====================================================
        // DORNE
        // =====================================================

        HouseName.Dayne => new House
        {
            Name = "Dayne",
            Motto = "No Known Motto",
            Description = "An ancient and prestigious Dornish house famous for the legendary sword Dawn.",
            Seat = "Starfall",
            Region = Regions.Dorne,
            Surname = "Dayne"
        },

        HouseName.Yronwood => new House
        {
            Name = "Yronwood",
            Motto = "We Guard the Way",
            Description = "One of the most powerful houses of Dorne, ruling the Boneway.",
            Seat = "Yronwood",
            Region = Regions.Dorne,
            Surname = "Yronwood"
        },

        HouseName.Fowler => new House
        {
            Name = "Fowler",
            Motto = "Let Me Soar",
            Description = "An ancient Dornish house ruling the Prince's Pass.",
            Seat = "Skyreach",
            Region = Regions.Dorne,
            Surname = "Fowler"
        },

        HouseName.Uller => new House
        {
            Name = "Uller",
            Motto = "No Known Motto",
            Description = "A powerful Dornish house ruling the hot and unforgiving lands around Hellholt.",
            Seat = "Hellholt",
            Region = Regions.Dorne,
            Surname = "Uller"
        },

        HouseName.Manwoody => new House
        {
            Name = "Manwoody",
            Motto = "No Known Motto",
            Description = "A noble house of Dorne sworn to House Martell.",
            Seat = "Kingsgrave",
            Region = Regions.Dorne,
            Surname = "Manwoody"
        },

        HouseName.Allyrion => new House
        {
            Name = "Allyrion",
            Motto = "No Known Motto",
            Description = "A noble Dornish house ruling the lands around Godsgrace.",
            Seat = "Godsgrace",
            Region = Regions.Dorne,
            Surname = "Allyrion"
        },

        HouseName.Jordayne => new House
        {
            Name = "Jordayne",
            Motto = "Let It Be Written",
            Description = "An ancient Dornish house with close ties to the coast.",
            Seat = "The Tor",
            Region = Regions.Dorne,
            Surname = "Jordayne"
        },

        HouseName.Toland => new House
        {
            Name = "Toland",
            Motto = "No Known Motto",
            Description = "A noble Dornish house known for its dragon-shaped sigil.",
            Seat = "Ghost Hill",
            Region = Regions.Dorne,
            Surname = "Toland"
        },

        HouseName.Qorgyle => new House
        {
            Name = "Qorgyle",
            Motto = "No Known Motto",
            Description = "A noble house of Dorne ruling lands near the western desert.",
            Seat = "Sandstone",
            Region = Regions.Dorne,
            Surname = "Qorgyle"
        },

        HouseName.Vaith => new House
        {
            Name = "Vaith",
            Motto = "No Known Motto",
            Description = "A noble house of Dorne ruling lands around the Vaith river.",
            Seat = "Vaith",
            Region = Regions.Dorne,
            Surname = "Vaith"
        },

        HouseName.Wyl => new House
        {
            Name = "Wyl",
            Motto = "No Known Motto",
            Description = "A fierce Dornish house ruling the Wyl lands near the Boneway.",
            Seat = "Wyl",
            Region = Regions.Dorne,
            Surname = "Wyl"
        },

        HouseName.Martell => new House
        {
            Name = "Martell",
            Motto = "Unbowed, Unbent, Unbroken",
            Description = "The ruling house of Dorne, preserving the unique traditions and independence of the Dornish.",
            Seat = "Sunspear",
            Region = Regions.Dorne,
            Surname = "Martell"
        },


        // =====================================================
        // CROWNLANDS
        // =====================================================

        HouseName.Massey => new House
        {
            Name = "Massey",
            Motto = "No Known Motto",
            Description = "An ancient house of the Crownlands sworn to the Iron Throne.",
            Seat = "Stonedance",
            Region = Regions.Crownlands,
            Surname = "Massey"
        },

        HouseName.Darklyn => new House
        {
            Name = "Darklyn",
            Motto = "No Known Motto",
            Description = "An ancient Crownlands house that once ruled from Duskendale.",
            Seat = "Duskendale",
            Region = Regions.Crownlands,
            Surname = "Darklyn"
        },

        HouseName.Rosby => new House
        {
            Name = "Rosby",
            Motto = "No Known Motto",
            Description = "A noble Crownlands house situated close to King's Landing.",
            Seat = "Rosby",
            Region = Regions.Crownlands,
            Surname = "Rosby"
        },

        HouseName.Stokeworth => new House
        {
            Name = "Stokeworth",
            Motto = "No Known Motto",
            Description = "A noble Crownlands house whose lands lie north of King's Landing.",
            Seat = "Stokeworth",
            Region = Regions.Crownlands,
            Surname = "Stokeworth"
        },

        HouseName.Rykker => new House
        {
            Name = "Rykker",
            Motto = "No Known Motto",
            Description = "A Crownlands house associated with Duskendale.",
            Seat = "Duskendale",
            Region = Regions.Crownlands,
            Surname = "Rykker"
        },

        HouseName.Bar_Emmon => new House
        {
            Name = "Bar Emmon",
            Motto = "No Known Motto",
            Description = "A Crownlands house ruling Sharp Point on Massey's Hook.",
            Seat = "Sharp Point",
            Region = Regions.Crownlands,
            Surname = "Bar Emmon"
        },

        HouseName.Brune => new House
        {
            Name = "Brune",
            Motto = "No Known Motto",
            Description = "A noble Crownlands house sworn to the Iron Throne.",
            Seat = "Dyre Den",
            Region = Regions.Crownlands,
            Surname = "Brune"
        },

        HouseName.Buckwell => new House
        {
            Name = "Buckwell",
            Motto = "Proud and Free",
            Description = "A noble house of the Crownlands sworn directly to the Iron Throne.",
            Seat = "Antlers",
            Region = Regions.Crownlands,
            Surname = "Buckwell"
        },

        HouseName.Hollard => new House
        {
            Name = "Hollard",
            Motto = "No Known Motto",
            Description = "A minor Crownlands house historically associated with Duskendale.",
            Seat = "Hollard lands",
            Region = Regions.Crownlands,
            Surname = "Hollard"
        },

        HouseName.Sunglass => new House
        {
            Name = "Sunglass",
            Motto = "No Known Motto",
            Description = "A Crownlands house ruling lands near Blackwater Bay.",
            Seat = "Sweetport Sound",
            Region = Regions.Crownlands,
            Surname = "Sunglass"
        },


        // =====================================================
        // UNKNOWN
        // =====================================================

        _ => throw new ArgumentException(
            $"Unknown house: {houseName}")
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