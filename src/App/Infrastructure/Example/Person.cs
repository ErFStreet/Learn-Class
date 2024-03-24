namespace App.Infrastructure.Example;

// .... abstract class -- just you can use to inheritance
public abstract class Person
{
    // No public Constructure ! because can not creating new of (Person) or object

    // You can protected Constracture
    protected Person()
    {
        // you can give value 

        FirstName = "Erfan";

        LastName = "Edalati";

        NickNames = new List<string>();
    }

    // You can write a public property
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public List<string> NickNames { get; set; }

    // You can write a method but just a public method for access in other classes
    public void AddNickName(string nickName)
    {
        NickNames.Add(item: nickName);
    }
}
