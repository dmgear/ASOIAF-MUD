using System.Security.Cryptography;
using System.Text;

namespace TheLongNight.Accounts;

public class AuthenticationService
{
    private readonly AccountRepository _repository;

    public AuthenticationService(AccountRepository repository)
    {
        _repository = repository;
    }

    public Account? Register()
    {
        Console.Write("Choose a username: ");
        string username = Console.ReadLine() ?? "";

        List<Account> accounts = _repository.GetAccounts();

        if (accounts.Any(a =>
            a.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("That username is already taken.");
            return null;
        }

        Console.Write("Choose a password: ");
        string password = Console.ReadLine() ?? "";

        Account account = new Account
        {
            Username = username,
            PasswordHash = HashPassword(password)
        };

        _repository.AddAccount(account);

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

        List<Account> accounts = _repository.GetAccounts();

        Account? account = accounts.FirstOrDefault(a =>
            a.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

        if (account == null)
        {
            Console.WriteLine("Invalid username or password.");
            return null;
        }

        if (!VerifyPassword(password, account.PasswordHash))
        {
            Console.WriteLine("Invalid username or password.");
            return null;
        }

        Console.WriteLine();
        Console.WriteLine($"Welcome, {account.Username}!");

        return account;
    }

    private static string HashPassword(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);

        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            100_000,
            HashAlgorithmName.SHA256,
            32);

        return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
    }

    private static bool VerifyPassword(string password, string storedHash)
    {
        string[] parts = storedHash.Split(':');

        if (parts.Length != 2)
            return false;

        byte[] salt = Convert.FromBase64String(parts[0]);
        byte[] expectedHash = Convert.FromBase64String(parts[1]);

        byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            100_000,
            HashAlgorithmName.SHA256,
            32);

        return CryptographicOperations.FixedTimeEquals(
            actualHash,
            expectedHash);
    }
}