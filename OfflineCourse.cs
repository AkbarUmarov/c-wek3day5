public class OfflineCourse : Course
{
    public OfflineCourse(string t, double b, int h) :base(t,b,h){}

    public override double CalculatePrice()
    {
        return BasePrice * Hours*1.15;
    }
}