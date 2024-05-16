using System;

/*
 *  POHDINTA jos se piti ees tänne laittaa
 * apstraktit luokat voi tarjota valmiin osittaisen toteutuksen ja sisältää erilaisia metodeja(?) toisin ku rajapinnat määrittelee vaan "toimintojen"? rakenteen.
molempia tarvitaan eri tilanteissa, apstrakteja silloin jos halutaan luoda monia kohtuu samanlaisia luokkia joita ei tarvii muokata paljoa.
Rajapintoja kannattaa käyttää jos pitää luoda monia enemmän erilaisia luokkia, joissa on enemmän muokattavuutta*/




//kaskyt alka
public interface IRobottiKasky // tammonen
{
    void Suorita(Robotti robotti);
}
public class Kaynnista : IRobottiKasky
{
    public void Suorita(Robotti robotti)
    {
        robotti.OnKaynnissa = true;
    }
}
public class Sammuta : IRobottiKasky
{
    public void Suorita(Robotti robotti)
    {
        robotti.OnKaynnissa = false;
    }
}
public class YlosKasky : IRobottiKasky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKaynnissa)
            robotti.Y++;
    }
}
public class AlasKasky : IRobottiKasky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKaynnissa)
            robotti.Y--;
    }
}
public class VasenKasky : IRobottiKasky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKaynnissa)
            robotti.X--;
    }
}
public class OikeaKasky : IRobottiKasky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKaynnissa)
            robotti.X++;
    }
}


//


public class Robotti //eka
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool OnKaynnissa { get; set; }
    public IRobottiKasky?[] Kaskyt { get; } = new IRobottiKasky?[3];

    public void Suorita()
    {
        foreach (IRobottiKasky? kasky in Kaskyt)
        {
            kasky?.Suorita(this);
            Console.WriteLine($"[{X} {Y} {OnKaynnissa}]");
        }
    }
}
//pää klassi
class Program
{
    static void Main(string[] args)
    {
        Robotti robotti = new Robotti();

        ////kaskyt

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Mita kaskyja robotille? Vaihtoehdot: käynnistä, sammuta, ylos, alas, oikea, vasen. {i + 1}/3: ");
            string kaskyStr = Console.ReadLine();

            switch (kaskyStr.ToLower())
            {
                case "käynnistä":
                    robotti.Kaskyt[i] = new Kaynnista();
                    break;
                case "sammuta":
                    robotti.Kaskyt[i] = new Sammuta();
                    break;
                case "ylos":
                    robotti.Kaskyt[i] = new YlosKasky();
                    break;
                case "alas":
                    robotti.Kaskyt[i] = new AlasKasky();
                    break;
                case "vasen":
                    robotti.Kaskyt[i] = new VasenKasky();
                    break;
                case "oikea":
                    robotti.Kaskyt[i] = new OikeaKasky();
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
