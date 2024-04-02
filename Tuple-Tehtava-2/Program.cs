using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Enumit;

internal class Program
{
    public static void Main()
    {
        Enumit.Paaaine paaaine = Enumit.Paaaine.Nautaa;
        Enumit.Lisuke lisuke = Enumit.Lisuke.Perunaa;
        Enumit.Kastike kastike = Enumit.Kastike.Curry;
        bool vapaa = false;
        int index0 = 0;
        int index1 = 0;
        int index2 = 0;
        Console.CursorVisible = false;

        


        while (true)
        {
            if (vapaa == true)
            {
                break;
            }
            Console.Clear();
            Console.WriteLine($"Q vaihtaa paaineen, W lisukkeen ja E kastikkeen");
            Console.WriteLine($"Paa-aine: {index0} {paaaine}");
            Console.WriteLine($"Lisuke: {index1} {lisuke}");
            Console.WriteLine($"Kastike: {index2} {kastike}");
            Console.WriteLine($"Paina S tallentaaksesi valinasti");
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Q:
                    if (index0 < 2)
                    {
                        index0 = index0 + 1;
                        paaaine = (Enumit.Paaaine)index0;
                    }
                    else
                    {
                        index0 = 0;
                        paaaine = (Enumit.Paaaine)index0;
                    }
                    break;
                default:
                    break;
            }
            switch (key.Key)
            {
                case ConsoleKey.W:
                    if (index1 < 2)
                    {
                        index1 = index1 + 1;
                        lisuke = (Enumit.Lisuke)index1;
                    }
                    else
                    {
                        index1 = 0;
                        lisuke = (Enumit.Lisuke)index1;
                    }
                    break;
                default:
                    break;
            }
            switch (key.Key)
            {
                case ConsoleKey.E:
                    if (index2 < 3)
                    {
                        index2 = index2 + 1;
                        kastike = (Enumit.Kastike)index2;
                    }
                    else
                    {
                        index2 = 0;
                        kastike = (Enumit.Kastike)index2;
                    }
                    break;
                default:
                    break;
            }
            switch (key.Key)
            {
                case ConsoleKey.S:
                    //(paaaine, lisuke, kastike) ruoka;
                    var ruoka = (paaaine, lisuke, kastike);
                    vapaa = true;
                    break;
                default:
                    
                    break;
            }
        }
        Console.Clear();
        Console.WriteLine($"{paaaine} ja {lisuke} {kastike}-kastikkeella");
    }
}