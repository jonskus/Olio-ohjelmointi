﻿using Harjoitus9;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {
        Kanava yleradio = new Kanava("yleradio", 100);
        Kanava mtv3 = new Kanava("mtv3", 101);
        Kanava puskaradio = new Kanava("puskaradio", 102);
        Kanava hasunhauskaradio = new Kanava("hasunhauskaradio", 103);
        Radio radio = new Radio();
        Console.WriteLine("Tervetuloa radioon, alin taajuus on 88 ja ylin taajuus 107.9");
        while (true)
        {
            Console.WriteLine("1. Aseta taajuus");
            Console.WriteLine("2. Aseta volume");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                if (value == 1)
                {
                    MuunnaTaajuus();
                }
                if (value == 2 )
                {
                    MuunnaAanenvoimakkuus();
                }
            }
            else
            {
                Console.WriteLine("Syötä numero.");
                Thread.Sleep(100);
            }
        }
        void MuunnaTaajuus()
        {
            //looppaa kunnes on asettanut taajuuden
            while (true)
            {
                Console.Write("Aseta taajuus: ");
                //katsoo jos taajuus on numero
                if (int.TryParse(Console.ReadLine(), out int taajuus))
                {
                    //asettaa taajuuden jos voi
                    try
                    {
                        radio.TaajuusSaadin(taajuus);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    //kertoo millä kanavalla on
                    foreach (KeyValuePair<float, string> i in Kanava.kanavat)
                    {
                        if (i.Key == taajuus)
                        {
                            Console.WriteLine("Olet nyt kanavalla " + i.Value);
                        }
                    }
                    break;
                }
                else { Console.WriteLine("Aseta numero"); }
            }
        }
        void MuunnaAanenvoimakkuus()
        {
            while (true)
            {
                //Kysyy äänenvoimakkuutta
                Console.Write("Aseta äänenvoimakkuus: ");
                if (int.TryParse(Console.ReadLine(), out int aanenvoimakkuus))
                {
                    //asettaa äänenvoimakkuuden jos voi
                    try
                    {
                        radio.AanenvoimakkuusSaadin(aanenvoimakkuus);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    //kertoo äänenvoimakkuuden
                    Console.WriteLine("Radion äänenvoimakkuus on nyt " + radio.Aanenvoimakkuus);
                    break;
                }
                else { Console.WriteLine("Aseta numero"); }
            }
        }
    }
}