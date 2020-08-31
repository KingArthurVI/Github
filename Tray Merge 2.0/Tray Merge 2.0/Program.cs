using System;
using System.Linq;
using System.Threading;

namespace Tray_Merge_2._0
{
    class Program
    {
        private static Random sca = new Random();
        private static Random rng = new Random();

        public static void Main()
        {
            Tray tray = new Tray();
            while (tray.pLength <= 495 && tray.pWidth <= 245 && tray.pHeight <= 345)            // Loopen går så lenge variablene er innenfor 490, 240, 340
            {


                if (tray.pLength > 300 && tray.pWidth > 175)
                {
                    Console.WriteLine("Large tray: Product " + tray.pLength + "mm long, " + tray.pWidth + "mm wide, " + tray.pHeight + "mm high, " + "TrayCode " + randomS(12));      // Fint å kunne oppgi produktets forskjellige lengde, høyde og bredde
                }

                else if (tray.pLength <= 300 && tray.pWidth <= 175)
                {
                    Console.WriteLine("Small tray: Product " + tray.pLength + "mm long, " + tray.pWidth + "mm wide, " + tray.pHeight + "mm high, " + "TrayCode " + randomS(12));
                }

                else if (tray.pLength > 300 && tray.pWidth <= 175)                // Om produktet er langt, men ikke bredt blir det lagt på et stort brett
                {
                    Console.WriteLine("Large tray: Product " + tray.pLength + "mm long, " + tray.pWidth + "mm wide, " + tray.pHeight + "mm high, " + "TrayCode " + randomS(12));
                }

                else if (tray.pLength <= 300 && tray.pWidth > 175)                // Om produktet er kort, men bredt blir det lagt på et stort brett
                {
                    Console.WriteLine("Large tray: Product " + tray.pLength + "mm long, " + tray.pWidth + "mm wide, " + tray.pHeight + "mm high, " + "TrayCode " + randomS(12));
                }
                tray = new Tray();
                Thread.Sleep(1000);
            }

            if (tray.pLength == 496 || tray.pWidth == 247 || tray.pHeight == 348)
            {              
                lightBarrier();
            }

            else if (tray.pLength == 498 || tray.pWidth == 249 || tray.pHeight == 350)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Conveying time ");
            }

            else if (tray.pLength == 499 || tray.pWidth == 250 || tray.pHeight == 346)
            {
                Console.WriteLine("Tray wrong turned on track ");
            }

            else if (tray.pLength == 500 || tray.pWidth == 246 || tray.pHeight == 349)
            {
                scannerReset();
            }

            else if (tray.pLength == 497 || tray.pWidth == 248 || tray.pHeight == 347)
            {
                Console.WriteLine("Product not turned. Product read " + tray.pLength + "mm long. " + tray.pWidth + "mm wide. " + tray.pHeight + "mm high.");
            }

            Console.WriteLine("Resume tray merge enter 'OK' ");
            programResume();
        }


        public static void programResume()     //Restart av programmet ved feil. Her må det kviteres med "OK" om du skal få starta programmet igjen
        {
            string writeR = Console.ReadLine();

            while (writeR != "OK")
            {
                if (writeR == "ok")
                {
                    Console.WriteLine("Use caps!");
                    writeR = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Unknown command");
                    writeR = Console.ReadLine();
                }

            }
            Main();
        }

        public static void lightBarrier()
        {
            Console.WriteLine("Light barrier broken ");

            int keyTurns = 0;

            while (keyTurns < 4)
            {

                switch (keyTurns)
                {
                    case 0:
                        Console.WriteLine("Press 'L' 4 More times");
                        break;

                    case 1:
                        Console.WriteLine(" 3 More times");
                        break;

                    case 2:
                        Console.WriteLine(" 2 More times");
                        break;

                    case 3:
                        Console.WriteLine(" 1 More time");
                        break;


                }

                ConsoleKeyInfo L = Console.ReadKey();
                if (L.KeyChar == 'L' || L.KeyChar == 'l')
                {
                    keyTurns++;
                }

                else
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("ight barrier was reset");
        }

        public static void scannerReset()
        {
            int scanP;
            scanP = sca.Next(0, 95);
            Console.WriteLine("Scanner read low");
            Console.WriteLine("Press 'V' to check reading level...");
            Console.WriteLine("Press 'R' to reset the scanner...");

            ConsoleKeyInfo S = Console.ReadKey();
            if (S.KeyChar == 'V' || S.KeyChar == 'v')
            {
                Console.WriteLine("Standard scanner level < 95%");
                Console.WriteLine("Scanner level" + scanP + "%");
            }

            else if (S.KeyChar == 'R' || S.KeyChar == 'r')
            {
                Console.WriteLine("Scanner was reset");
            }

            else
            {
                Console.WriteLine("Unknown command");
            }


        
        }
        public static string randomS(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rng.Next(s.Length)]).ToArray());
        }

    }   
    class Tray
    {
        private static Random rnd = new Random();         
        public int pLength;
        public int pWidth;
        public int pHeight;
        public Tray()
        {
            pLength = rnd.Next(100, 500);
            pWidth = rnd.Next(100, 250);
            pHeight = rnd.Next(100, 350);
        }
    }
}
