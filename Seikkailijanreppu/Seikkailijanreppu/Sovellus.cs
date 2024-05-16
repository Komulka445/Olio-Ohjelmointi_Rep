using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeikkailijanReppu
{
    public class Sovellus
    {
        Reppu reppu;

        public void Run()
        {
            reppu = new Reppu(10, 30, 20);
            while (true)
            {
                Console.Clear();
                //sisältö, uss homma
                Console.WriteLine("Repun sisältö: " + reppu.ToString());
                Console.WriteLine($"Repun status:\nPaikat {reppu.tavaroidenMaara}/{reppu.maxtavarat}\nPaino {reppu.nykpaino}/{reppu.maxpaino}\nTilavuus {reppu.nyktilavuus}/{reppu.maxpaino}");
                Console.WriteLine("Mitä tahdot lisätä?\n1 - nuoli\n2 - jousi\n3 - köysi\n4 - Vettä\n5 - Ruokaa\n6 - Miekka");
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        reppu.Lisää(new Nuoli());
                        break;
                    case ConsoleKey.D2:
                        reppu.Lisää(new Jousi());
                        break;
                    case ConsoleKey.D3:
                        reppu.Lisää(new Köysi());
                        break;
                    case ConsoleKey.D4:
                        reppu.Lisää(new Vesi());
                        break;
                    case ConsoleKey.D5:
                        reppu.Lisää(new Ruoka());
                        break;
                    case ConsoleKey.D6:
                        reppu.Lisää(new Miekka());
                        break;
                    default:
                        Console.WriteLine("Virhe");
                        break;
                }

            }
        }
    }
}
