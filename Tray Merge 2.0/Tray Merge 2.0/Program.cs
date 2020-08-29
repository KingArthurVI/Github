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
                    Console.WriteLine("Large Tray");
                }

                else if (tray.pLength <= 300 && tray.pWidth <= 125)
                {
                    Console.WriteLine("Small Tray");
                }

                else if (tray.pLength > 300 && tray.pWidth <= 125)                // Om produktet er langt, men ikke bredt blir det lagt på et stort brett
                {
                    Console.WriteLine("Large Tray");
                }

                else if (tray.pLength <= 300 && tray.pWidth > 125)                // Om produktet er kort, men bredt blir det lagt på et stort brett
                {
                    Console.WriteLine("Large Tray");
                }
                tray = new Tray();
                Thread.Sleep(1000);
            }

            if (tray.pLength == 496 || tray.pWidth == 246 || tray.pHeight == 346)
            {
                Console.WriteLine("Light barrier broken");
            }

            else if ()
            {

            }
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
