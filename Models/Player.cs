namespace TheLongNight.Models;

public class Player
{
    public string Name { get; set; } = "";
    public int Health { get; set; } = 100;
    public int MaxHealth { get; set; } = 100;

    public int Level { get; set; } = 1;
    public int Gold { get; set; } = 10;

    public string Location { get; set; } = "";
}