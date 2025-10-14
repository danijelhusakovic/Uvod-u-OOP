public class Kruznica : GeometrijskiLik
{
    public Tocka s;
    public double radius;

    public Kruznica(Tocka s, double radius)
    {
        this.s = s;
        this.radius = radius;
    }

    public override double Opseg()
    {
        throw new NotImplementedException();
    }

    public override double Povrsina()
    {
        throw new NotImplementedException();
    }
}