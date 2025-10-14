public class Pravokutnik : GeometrijskiLik
{
    public Tocka a;
    public Tocka c;

    public Pravokutnik(Tocka a, Tocka c)
    {
        this.a = a;
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