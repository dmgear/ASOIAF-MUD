namespace TheLongNight.Characters;

public class Background 
{
    public Region Region { get; set; } = new Region();
    public HouseName? House { get; set; }
    public bool IsBastard { get; set; }
}