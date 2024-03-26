
using System.Runtime.Serialization;
using System.Security.Principal;

internal class Program
{

    //static public int bar = 2;

    public static void Main()
    {
        Enumit.States tila = Enumit.States.Lukossa;
        while (true)
        {
            Console.WriteLine($"Ovi on {tila}");
            Console.WriteLine("Mitä haluat tehdä ovelle? Paina kyseistä näppäintä suorittaaksesi toiminnon.\n(A) Avaa ovi\n(T) Vaihda lukituksen tila");
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.A:
                    if (tila == Enumit.States.Kiinni)
                    {
                        tila = Enumit.States.Auki;
                    }
                    else Console.WriteLine("Ovi on lukossa vielä, avaa lukitus ensin.");
                    break;
                case ConsoleKey.T:
                    if (tila == Enumit.States.Lukossa)
                    {
                        tila = Enumit.States.Kiinni;
                    }
                    else if (tila == Enumit.States.Kiinni)
                    {
                        tila = Enumit.States.Lukossa;
                    }
                    else Console.WriteLine("Ovi on auki, sulje ovi ennen");
                    break;
                default:
                    break;
            }
        }
    }
}
//STATIC SELITETTY, CLASSI, JOSTA TEHDÄÄN OLIO, EI SISÄLLÄ STAATTISIA ASIOITA, ESIM MUUTTUJAT METODIT JNE
                /*
        Toinen a = new Toinen();
        a.eka = 2;
        Toinen.printme();
        Toinen.bar = 4;
        Toinen b = new Toinen();
        b.eka = 4;
        Toinen.bar = a.eka;
        Toinen.printme();
        */
/*
    private void  fooo()
{

}

internal class Toinen
{
    public int eka;
    public static int bar;

    static public void printme()
    {
        Console.WriteLine($"{bar}");
    }
}
}
*/