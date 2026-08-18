using System.Text.Json.Serialization;

namespace TheLongNight.Characters;

public class PlayerCharacter
{
    [JsonInclude]
    public string Name { get; internal set; } = "";

    [JsonInclude]
    public string Surname { get; internal set; } = "";

    [JsonInclude]
    public double Health { get; internal set; } = 100.0;

    [JsonInclude]
    public double MaxHealth { get; internal set; } = 100.0;

    [JsonInclude]
    public int Level { get; internal set; } = 1;

    [JsonInclude]
    public long Gold { get; internal set; } = 10;

    [JsonInclude]
    public string Location { get; internal set; } = "";

    [JsonInclude]
    public Background? Background { get; internal set; }

    [JsonInclude]
    public Rank WatchRank { get; internal set; }
}