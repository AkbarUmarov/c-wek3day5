public class OnlineCourse : Course
{
    public OnlineCourse(string t, double b, int h) :base(t,b,h){}

    public override double CalculatePrice()
    {
        return BasePrice * Hours*0.9;
    }
}