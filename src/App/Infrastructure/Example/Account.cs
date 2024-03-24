namespace App.Infrastructure.Example;

public class Account : Person // ... inheritanced from Person
{
    public Account(string userName,string password)
    {
        UserName = userName;

        Password = password;
    }

    public string UserName { get; set; }

    public string Password { get; set; }

    public bool IsActived { get; set; }
}
