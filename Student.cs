public class Student : Person
{
    public string GroupName{get; set;}

    public override void Notify(string message)
    {
        System.Console.WriteLine(message);
    }
    public override string ShorInfo()
    {
        return "This is Student";
        
    }
}