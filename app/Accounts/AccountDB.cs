using System.Text.Json;

namespace TheLongNight.Accounts;

public class AccountRepository
{
    private readonly string _filePath = "accounts.json";

    public List<Account> GetAccounts()
    {
        if (!File.Exists(_filePath))
        {
            return new List<Account>();
        }

        string json = File.ReadAllText(_filePath);

        return JsonSerializer.Deserialize<List<Account>>(json)
               ?? new List<Account>();
    }

    public void SaveAccounts(List<Account> accounts)
    {
        string json = JsonSerializer.Serialize(
            accounts,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(_filePath, json);
    }

    public void AddAccount(Account account)
    {
        List<Account> accounts = GetAccounts();

        accounts.Add(account);

        SaveAccounts(accounts);
    }
}