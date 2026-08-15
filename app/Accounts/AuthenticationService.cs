public class AuthenticationService
{
    public Account Register()
    {
        Account account = new Account();

        Console.Write("Choose a username: ");
        account.Username = Console.ReadLine() ?? "";

        Console.Write("Choose a password: ");
        account.Password = Console.ReadLine() ?? "";

        Console.WriteLine();
        Console.WriteLine($"Account {account.Username} created.");

        return account;
    }

    public Account? Login()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine() ?? "";

        Console.Write("Password: ");
        string password = Console.ReadLine() ?? "";

        // Temporary authentication until we have account storage.
        Console.WriteLine();
        Console.WriteLine($"Welcome, {username}!");

        return new Account
        {
            Username = username,
            Password = password
        };
    }
}