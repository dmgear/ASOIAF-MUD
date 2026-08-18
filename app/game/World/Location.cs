namespace TheLongNight.World;

public class Location
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public Dictionary<string, string> Exits { get; set; } = new();

    public List<Location> Children { get; set; } = new();
}