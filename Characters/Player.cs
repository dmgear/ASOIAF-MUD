namespace TheLongNight.Characters;

public class Player
{
    public string Name { get; set; } = "";
    public int Health { get; set; } = 100;
    public int MaxHealth { get; set; } = 100;

    public Rank Rank { get; set; } = Rank.Recruit;
    public Order Order { get; set; };

    public int Level { get; set; } = 1;
    public int Gold { get; set; } = 10;

    public string Location { get; set; } = "";
}