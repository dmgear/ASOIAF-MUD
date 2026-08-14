namespace TheLongNight.Models;

public class Player
{
    public string Name { get; internal set; } = "";
    public double Health { get; internal set; } = 100.0;
    public double MaxHealth { get; internal set; } = 100.0;

    public int Level { get; internal set; } = 1;
    public long Gold { get; internal set; } = 10;

    public string Location { get; internal set; } = "";
}