public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        this._radius = radius;
    }

    public override double GetArea()
    {
        double result = Math.PI * Math.Pow(_radius, 2);
        return Math.Round(result, 2);
    }
}