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
    bool lapi = false;

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

    public static Nuoli LuoEliittiNuoli()
    {
        Nuoli nuoli = new Nuoli();
        nuoli.karki = karjet.timantti;
        nuoli.sulka = sulat.kotkansulka;
        nuoli.pituus = "100";
        nuoli.price = 90f;
        return nuoli;
    }

    public static Nuoli LuoAloittelijanuoli()
    {
        Nuoli nuoli = new Nuoli();
        nuoli.karki = karjet.puu;
        nuoli.sulka = sulat.kanansulka;
        nuoli.pituus = "70";
        nuoli.price = 35f;
        return nuoli;
    }

    public static Nuoli LuoPerusnuoli()
    {
        Nuoli nuoli = new Nuoli();
        nuoli.karki = karjet.teras;
        nuoli.sulka = sulat.kanansulka;
        nuoli.pituus = "85";
        nuoli.price = 50f;
        return nuoli;
    }

    public void Suorita()
    { Nuoli tempnuol = new Nuoli();
        Console.WriteLine("Haluatko valita yhden esiluoduista nuolista vai haluatko RÄÄTÄLÖIDÄ oman nuolen? (E / R)");
        ConsoleKeyInfo avain = Console.ReadKey(true);
        switch (avain.Key)
        {
            case ConsoleKey.E:
                Console.Clear();
                Console.WriteLine("Vaihtoehdot ovat:\n(A) 100cm Eliittinuoli, timanttikärjellä ja kotkansulalla. Maksaa 95.\n(B) 85cm Perusnuoli, teräskärjellä ja kanansulalla. Maksaa 54.\n(C) 70cm Aloittelijanuoli, puukärjellä ja kanansulalla. Maksaa 38.");
                ConsoleKeyInfo avain2 = Console.ReadKey(true);
                switch (avain2.Key)
                {
                    case ConsoleKey.A:
                        tempnuol = LuoEliittiNuoli();
                        Console.WriteLine($"{tempnuol.karki} {tempnuol.sulka} {tempnuol.pituus}cm maksaa {tempnuol.price} rahaa");
                        break;
                    default:
                        break;
                }
                switch (avain2.Key)
                {
                    case ConsoleKey.B:
                        tempnuol = LuoPerusnuoli();
                        Console.WriteLine($"{tempnuol.karki} {tempnuol.sulka} {tempnuol.pituus}cm maksaa {tempnuol.price} rahaa");
                        break;
                    default:
                        break;
                }
                switch (avain2.Key)
                {
                    case ConsoleKey.C:
                        tempnuol = LuoAloittelijanuoli();
                        Console.WriteLine($"{tempnuol.karki} {tempnuol.sulka} {tempnuol.pituus}cm maksaa {tempnuol.price} rahaa");
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
        switch (avain.Key)
        {
            case ConsoleKey.R:
                lapi = true;
                Console.Clear();
                break;
            default:
                break;
        }

        if (lapi == true)
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
                    Console.WriteLine("Nuoli maksaa " + fPrice + " rahaa. Valitsit nuolen pituudeksi " + fPituus + " yksikköä, sulaksi " + sulka + "n ja kärjeksi " + karki + "n\nNuolen hinta on pyöristetty lähimpään kokonaislukuun.");
                    break;
                }
            }
        }
        else if (lapi == false || pituus != null)
        {
            int fPituus = Int32.Parse(tempnuol.pituus);
            if (fPituus < 101 && fPituus > 59)
            {
                tempnuol.price = tempnuol.price + (fPituus * 0.05f);
                int fPrice = Convert.ToInt32(tempnuol.price);
                //Console.WriteLine(karki + " " + sulka + " " + fPituus+" "+fPrice);
                Console.Clear();
                Console.WriteLine("Nuoli maksaa " + fPrice + " rahaa. Valitsit nuolen pituudeksi " + fPituus + " yksikköä, sulaksi " + tempnuol.sulka + "n ja kärjeksi " + tempnuol.karki + "n\nNuolen hinta on pyöristetty lähimpään kokonaislukuun.");
            }
        }
        else
        {
            Console.WriteLine("Tuntematon virhe tapahtui. Ohjelma sammuu.");
        }
    }

}

