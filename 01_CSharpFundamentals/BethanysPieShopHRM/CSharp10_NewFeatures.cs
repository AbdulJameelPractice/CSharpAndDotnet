namespace BethanysPieShopHRM;
public class CSharp10NewFeatures
{
    public const string AppFile = "help.txt";
    public const string BethnyasName = $"{AppFile}/Behanays.txt";

    public DateOnly date = new DateOnly(10,2,3);
    public TimeOnly time = new TimeOnly(12, 12, 12);

    public void PrintData()
    {
        Console.WriteLine("CSharp10NewFeatures");
        Console.WriteLine(date.ToLongDateString());
        Console.WriteLine(time.ToLongTimeString());
        
        
        Console.WriteLine(Environment.ProcessId);
        Console.WriteLine(Environment.ProcessPath);
    }
}