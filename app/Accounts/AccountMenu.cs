namespace TheLongNight.Accounts;

public class AccountMenu
{
    private readonly AuthenticationService _authentication;

    public AccountMenu(AuthenticationService authentication)
    {
        _authentication = authentication;
    }

    public Account? Show()
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("          THE LONG NIGHT");
        Console.WriteLine("=================================");
        Console.WriteLine();

        Console.WriteLine("1. Login");
        Console.WriteLine("2. Create Account");
        Console.WriteLine();

        Console.Write("Choice: ");

        string choice = Console.ReadLine() ?? "";

        return choice switch
        {
            "1" => _authentication.Login(),
            "2" => _authentication.Register(),
            _ => null
        };
    }
}