namespace BethanysPieShopHRM;

public class CSharrp11Features
{
    private readonly string _message = """
                                      this is very long string.
                                      it spans multiple lines
                                      """;

    public void PrintData()
    {
        Console.WriteLine("CSharp11NewFeatures");
        Console.WriteLine(_message);
        
        string anotherMessage = $"""
                                 {_message} 
                                  and now added with more data
                                 """;
        
        Console.WriteLine(anotherMessage);

        Person newPerson = new Person()
        {
            FirstName = "sample name"
        };

        Person anotherPerson = new Person()
        {
            FirstName = null
        };
    }
}

/// <summary>
/// file scoped cannot be accessed outside of the file.
/// </summary>
file class Person
{
    public required string FirstName { get; set; }
}