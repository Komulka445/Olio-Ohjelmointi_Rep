using System;

//käskyt alkaa
public abstract class Robottikasky
{
    public abstract void Suorita(Robotti robotti); // ei toiminu ilman tätä apstraktia nii se on nyt siibä
}
public class Käynnistä : Robottikasky
{
    public override void Suorita(Robotti robotti)
    {
        robotti.Kaynnissa = true;
    }
}
public class Sammuta : Robottikasky
{
    public override void Suorita(Robotti robotti)
    {
        robotti.Kaynnissa = false;
    }
}
public class Yloskasky : Robottikasky
{
    public override void Suorita(Robotti robotti)
    {
        if (robotti.Kaynnissa)
            robotti.Y++;
    }
}
public class Alaskasky : Robottikasky
{
    public override void Suorita(Robotti robotti)
    {
        if (robotti.Kaynnissa)
            robotti.Y--;
    }
}
public class Vasenkasky : Robottikasky
{
    public override void Suorita(Robotti robotti)
    {
        if (robotti.Kaynnissa)
            robotti.X--;
    }
}
public class Oikeakasky : Robottikasky
{
    public override void Suorita(Robotti robotti)
    {
        if (robotti.Kaynnissa)
            robotti.X++;
    }
}

//


public class Robotti //eka
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool Kaynnissa { get; set; }
    public Robottikasky?[] kaskyt { get; } = new Robottikasky?[3];

    public void Suorita()
    {
        //loppuprompti
        foreach (Robottikasky? kasky in kaskyt)
        {
            kasky?.Suorita(this);
            Console.WriteLine($"[{X} {Y} {Kaynnissa}]");
        }
    }
}
//pää klässi
public class Program
{
    static void Main(string[] args)
    {
        Robotti robotti = new Robotti();

        ////kaskyt
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Mitä kaskyjä robotile=? Vaihtoehdot: käynnistä, sammuta, ylos, alas, oikea, vasen.{i + 1}/3: ");
            string kaskyStr = Console.ReadLine();

            switch (kaskyStr.ToLower())
            {
                case "käynnistä":
                    robotti.kaskyt[i] = new Käynnistä();
                    break;
                case "sammuta":
                    robotti.kaskyt[i] = new Sammuta();
                    break;
                case "ylos":
                    robotti.kaskyt[i] = new Yloskasky();
                    break;
                case "alas":
                    robotti.kaskyt[i] = new Alaskasky();
                    break;
                case "vasen":
                    robotti.kaskyt[i] = new Vasenkasky();
                    break;
                case "oikea":
                    robotti.kaskyt[i] = new Oikeakasky();
                    break;
                default:
                    Console.WriteLine("Tuntematon kasky.");
                    i--; //error prompti
                    break;
            }
        }

        //latoo kaskyt
        robotti.Suorita();
    }
}
