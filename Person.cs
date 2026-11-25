public abstract class Person : EntityBase
{
    public string FullName{get; set;}
    public string Email{get; set;}
    public string Phone{get; set;}

    public abstract void Notify (string message);

    public override void Validate()
    {
        System.Console.WriteLine("Проверка Email/FullName");
    }
    public virtual string ShorInfo()
    {
        return "This is Person";
    }
    
}