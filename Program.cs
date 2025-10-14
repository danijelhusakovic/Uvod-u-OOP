using System.Linq.Expressions;

internal class Program
    {
        static void Main(string[] args)
        {

        Tocka a = new Tocka(0, 0);
        Tocka b = new Tocka(1, 3);

        Kruznica k = new Kruznica(a, 10);
        Trokut trokut = new Trokut(a, b, new Tocka(3, 4));

        Duzina ab = new Duzina(a, b);

        }
    }