using System;

public class VaritettyTavara<T>
{
    /// <summary>
    /// /ominaisuudet
    /// /
    /// </summary>
    public T Tavara { get; }

    public ConsoleColor Vari { get;}
    public VaritettyTavara(T tavara, ConsoleColor vari)//kostru
    {
        Tavara = tavara;
        Vari = vari;
    }
    public void NaytaTavara()//nimvarit
    {
        ConsoleColor ogVari = Console.ForegroundColor;
        //varit varin takaisin muuttamiseemn että ei jää siniseks /\  \/ \/ \/
        Console.ForegroundColor = Vari;
        Console.WriteLine(Tavara.ToString());
        Console.ForegroundColor = ogVari;
    }

}
