namespace AreaOfCircle;

public class Circle
{
    public double Radius { get; set; }
    private double area;
    public double Area
    {
        get { return area; }
        set { area = Math.PI * Math.Pow(Radius, 2); }
    }
    private double circumference;
    public double Circumference 
    { 
        get { return circumference; }
        set { circumference = Math.PI * Radius* 2; }
    }

    private double diameter;
    public double Diameter
    {
        get { return diameter; }
        set { diameter = Radius * 2; }
    }

    public Circle(double radius) {
        Radius = radius;
        area = Math.PI * Math.Pow(Radius, 2);
        circumference = 2 * Math.PI * Radius;
        diameter = 2 * Radius;
    }

}
