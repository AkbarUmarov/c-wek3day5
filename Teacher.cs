public class Teacher : Person
{
    public override void Notify(string message)
    {
        System.Console.WriteLine(message);
    }
    public void Expertise()
    {
        System.Console.WriteLine("Teacher is cheking");
    }
    public override string ShorInfo()
    {
        return "This is Teacher";
    }
    
}