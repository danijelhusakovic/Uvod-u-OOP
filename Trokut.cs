public class Trokut : GeometrijskiLik
{
    public Tocka a;
    public Tocka b;
    public Tocka c;

    public Trokut(Tocka a, Tocka b, Tocka c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
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