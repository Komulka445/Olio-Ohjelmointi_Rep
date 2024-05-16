using System;
public struct Koordinaatti //vaadittu strukti homma
{
    public int X { get; }
    public int Y { get; }
    public Koordinaatti(int x, int y)//koordinattien arvot
    {
        X = x;
        Y = y;
    }
    //onko vierressä?
    public bool Vieressa(Koordinaatti toka)
    {
        return Math.Abs(X - toka.X) <= 1 && Math.Abs(Y - toka.Y) <= 1;
    }
}
//pääsofta
class Program
{
    static void Main(string[] args)
    {//koodinaatit
        Koordinaatti keski = new Koordinaatti(0, 0);
        Koordinaatti[] tKoordinaatit = {
            new Koordinaatti(-1, -1),
            new Koordinaatti(-1, 0),
            new Koordinaatti(-1, 1),
            new Koordinaatti(0, -1),
            new Koordinaatti(0, 0),
            new Koordinaatti(0, 1),
            new Koordinaatti(1, -1),
            new Koordinaatti(1, 0),
            new Koordinaatti(1, 1)
        };////listaus
        foreach (var kNaatti in tKoordinaatit)
        {
            string viesti = kNaatti.Vieressa(keski) ? "on koordinaatin 0,0 vieressä" : "ei ole koordinaatin 0,0 vieressä";
            Console.WriteLine($"Annettu koordinaatti {kNaatti.X},{kNaatti.Y} {viesti}");
        }



    }
}

