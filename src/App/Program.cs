namespace App;

public class Program
{
    static void Main()
    {
        var account =
            new Account(userName: "ErFCode", password: "(ojan&619M)#4Kl");

        account.IsActived = true;

        account.AddNickName(nickName: "ErF Street");

        account.AddNickName(nickName: "ErF Code");

        Console.WriteLine(value: $"Fist Name: {account.FirstName}");

        Console.WriteLine(value: $"Last Name: {account.LastName}");

        Console.WriteLine(value: $"Is Actived: {account.IsActived}");

        Console.Write(value: $"Nick Names: ");

        foreach (var item in account.NickNames!)
        {
            Console.Write(value: $"{item} ");
        }
    }
}
