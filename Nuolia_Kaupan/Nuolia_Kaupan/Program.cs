using System;
using System.Numerics;
using static Nuoli;

public class Nuolia_Kaupan
{

    public static void Main()
    {
        Nuoli nuoli = new Nuoli();
        nuoli.Suorita();
    }
}

public class Nuoli
{
    public enum karjet
    {
        puu,
        teras,
        timantti
    }
    public enum sulat
    {
        lehti,
        kanansulka,
        kotkansulka
    }
    private string pituus;
    private karjet karki;
    private sulat sulka;
    float price = 0f;

    public string GetPituus()
    {
        return pituus;
    }

    public karjet GetKarki()
    {
        return karki;
    }

    public sulat GetSulka()
    {
        return sulka;
    }

    public float GetPrice()
    {
        return price;
    }


    public void Suorita()
    {
        Console.WriteLine($"Minkälainen kärki? Puu(3) [A], teräs(5) [B] vai timantti(50) [C]?");
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A:
                karki = karjet.puu;
                price = price + 3;
                break;
            default:
                break;
        }
        switch (key.Key)
        {
            case ConsoleKey.B:
                karki = karjet.teras;
                price = price + 5;
                break;
            default:
                break;
        }
        switch (key.Key)
        {
            case ConsoleKey.C:
                karki = karjet.timantti;
                price = price + 50;
                break;
            default:
                break;
        }
        Console.WriteLine($"Minkälainen sulka? lehti(0) [A], kanansulka(1) [B] vai kotkansulka(5) [C]?");
        ConsoleKeyInfo key2 = Console.ReadKey(true);
        switch (key2.Key)
        {
            case ConsoleKey.A:
                sulka = sulat.lehti;
                price = price + 0;
                break;
            default:
                break;
        }
        switch (key.Key)
        {
            case ConsoleKey.B:
                sulka = sulat.kanansulka;
                price = price + 1;
                break;
            default:
                break;
        }
        switch (key.Key)
        {
            case ConsoleKey.C:
                sulka = sulat.kotkansulka;
                price = price + 5;
                break;
            default:
                break;
        }
        while (true)
        {
            Console.WriteLine("Valitse nuolen pituus 60 - 100cm");
            pituus = Console.ReadLine();
            int fPituus = Int32.Parse(pituus);
            if (fPituus < 101 && fPituus > 59)
            {
                price = price + (fPituus * 0.05f);
                int fPrice = Convert.ToInt32(price);
                //Console.WriteLine(karki + " " + sulka + " " + fPituus+" "+fPrice);
                Console.Clear();
                Console.WriteLine("Nuoli maksaa "+fPrice+" rahaa. Valitsit nuolen pituudeksi "+fPituus+" yksikköä, sulaksi "+sulka+"n ja kärjeksi "+karki+"n\nNuolen hinta on pyöristetty lähimpään kokonaislukuun.");
                break;
            }
        }        
    }

}

