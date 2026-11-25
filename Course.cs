public abstract class Course : EntityBase
{
    public string Title {get; set;}
    public double BasePrice{get; set;}
    public int Hours {get; set;}

    public Course(){}

    public Course (string t, double b, int h)
    {
        Title = t;
        BasePrice = b;
        Hours = h;
    }
    public virtual double CalculatePrice()
    {
        return BasePrice*Hours;
    }
    public override void Validate()
    {
        if(Title.Length >= 2 && Hours>2)
        {
            System.Console.WriteLine("Yagonchi");
        }
        else
        {
            System.Console.WriteLine("Digarchi");
        }
    }
}