using System;
using System.Threading;

namespace Tray_Merge_2._0
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Tray tray = new Tray();
            while (tray.pLength <= 495 && tray.pWidth <= 245 && tray.pHeight <= 345)            // Loopen går så lenge variablene er innenfor 490, 240, 340
            {


                if (tray.pLength > 300 && tray.pWidth > 125)
                {
                    Console.WriteLine("Large Tray. Product " + tray.pLength + "mm long. " + tray.pWidth + "mm wide. " + tray.pHeight + "mm high.");     // Fint å kunne oppgi produktets forskjellige lengde, høyde og bredde
                }

                else if (tray.pLength <= 300 && tray.pWidth <= 125)
                {
                    Console.WriteLine("Small Tray Product " + tray.pLength + "mm long. " + tray.pWidth + "mm wide. " + tray.pHeight + "mm high.");
                }

                else if (tray.pLength > 300 && tray.pWidth <= 125)                // Om produktet er langt, men ikke bredt blir det lagt på et stort brett
                {
                    Console.WriteLine("Large Tray Product " + tray.pLength + "mm long. " + tray.pWidth + "mm wide. " + tray.pHeight + "mm high.");
                }

                else if (tray.pLength <= 300 && tray.pWidth > 125)                // Om produktet er kort, men bredt blir det lagt på et stort brett
                {
                    Console.WriteLine("Large Tray Product " + tray.pLength + "mm long. " + tray.pWidth + "mm wide. " + tray.pHeight + "mm high.");
                }
                tray = new Tray();
                Thread.Sleep(1000);
            }

            if (tray.pLength == 496 || tray.pWidth == 246 || tray.pHeight == 346)
            {
                Console.WriteLine("Light barrier broken");
            }

            else if (tray.pLength == 497 || tray.pWidth == 247 || tray.pHeight == 347)
            {
                Console.WriteLine("Conveying time");
            }

            else if (tray.pLength == 498 || tray.pWidth == 248 || tray.pHeight == 348)
            {
                Console.WriteLine("Tray wrong turned on track");
            }

            else if (tray.pLength == 499 || tray.pWidth == 249 || tray.pHeight == 349)
            {
                Console.WriteLine("Scanner read to low");
            }

            else if (tray.pLength == 500 || tray.pWidth == 500 || tray.pHeight == 500)
            {
                Console.WriteLine("Product not turned. Product read " + tray.pLength + "mm long. " + tray.pWidth + "mm wide. " + tray.pHeight + "mm high." );
            }

            Console.WriteLine("Write OK "); 
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
            pLength = rnd.Next(0, 500);
            pWidth = rnd.Next(0, 250);
            pHeight = rnd.Next(0, 350);
        }
    }
}
