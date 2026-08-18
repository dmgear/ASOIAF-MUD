using TheLongNight.Characters;

namespace TheLongNight.Accounts;

public class Account
{
    public string Username { get; set; } = "";
    public string PasswordHash { get; set; } = "";

    public List<PlayerCharacter> Characters { get; set; } = new();
}