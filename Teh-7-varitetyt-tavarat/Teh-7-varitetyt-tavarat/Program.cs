using System;
public class Program
{
    //public bool checker;
    public static void Main()
    {

        Console.CursorVisible = false;
        //instansitja tulostus
        VaritettyTavara<Nuoli> varitettuNuoli = new VaritettyTavara<Nuoli>(new Nuoli(), ConsoleColor.Red);
        //VaritettyTavara<Nuoli>.NaytaTavara;
        varitettuNuoli.NaytaTavara();
        VaritettyTavara<Jousi> varitettuJousi = new VaritettyTavara<Jousi>(new Jousi(), ConsoleColor.Green);
        varitettuJousi.NaytaTavara();
        VaritettyTavara<Ruoka> varitettuRuoka = new VaritettyTavara<Ruoka>(new Ruoka(), ConsoleColor.Blue);
        varitettuRuoka.NaytaTavara();


        Console.ReadLine();
    }

}


