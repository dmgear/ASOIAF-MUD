namespace TheLongNight.Characters;

public class Player
{
    public string Name { get; internal set; } = "";
    public string Surname { get; internal set; } = "";
    public double Health { get; internal set; } = 100.0;
    public double MaxHealth { get; internal set; } = 100.0;

    public int Level { get; internal set; } = 1;
    public long Gold { get; internal set; } = 10;

    public string Location { get; internal set; } = "";

    public Background Background { get; internal set; }

    public WatchRank Rank { get; internal set; }

    public void SetBackground(Background background)
    {
        Background = background;
    }

    
}