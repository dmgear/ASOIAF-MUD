public enum Region
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
    public string Seat { get; set; } = "";
}