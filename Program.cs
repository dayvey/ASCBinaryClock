using System;
using System.Xml.Linq;

namespace BinaryClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    int trec = 0;
            //    int prez = DateTime.Now.Second;
            //
            //    if (prez != trec)
            //   {
            //        Console.WriteLine("Hello there! {0}", prez);
            //        trec = prez;
            //    }
            //    Thread.Sleep(1000);
            //}
            int ora, min, sec;

            while (true)
            {
                Console.Clear();
                ora = DateTime.Now.Hour;
                min = DateTime.Now.Minute;
                sec = DateTime.Now.Second;

                int[] vectOra = { 0, 0, 0, 0, 0 };
                int[] vectMin = { 0, 0, 0, 0, 0, 0 };
                int[] vectSec = { 0, 0, 0, 0, 0, 0 };

                for (int i = 5; i >= 0; i--)
                {
                    if (i != 5)
                    {
                        vectOra[i] = ora % 2;
                        ora /= 2;
                    }
                    vectMin[i] = min % 2;
                    min /= 2;
                    vectSec[i] = sec % 2;
                    sec /= 2;
                }
                Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯");
                Console.WriteLine("|  {0} {1} {2} {3} {4}|", vectOra[0], vectOra[1], vectOra[2], vectOra[3], vectOra[4]);
                Console.WriteLine("|{0} {1} {2} {3} {4} {5}|", vectMin[0], vectMin[1], vectMin[2], vectMin[3], vectMin[4], vectMin[5]);
                Console.WriteLine("|{0} {1} {2} {3} {4} {5}|", vectSec[0], vectSec[1], vectSec[2], vectSec[3], vectSec[4], vectSec[5]);
                Console.WriteLine("|___________|");
                Thread.Sleep(1000);
            }
        }
        
    }
}