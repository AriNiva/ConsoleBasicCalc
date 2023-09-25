using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double dSumma = 0;
            string strSumma = "";
            string luku = "0";
            while (luku.Length > 0)//Length on stringin pituus.5=1 10=2jne.
            { 
                dSumma = dSumma + Double.Parse(luku);//Mennään silmukkaan, ensimmäisellä kierroksella intSumma + luku = 0+0
                Console.Write("Anna luku ({0}): ", dSumma.ToString());//({0}) viittaa parametriin intSumma.ToString.Ensimmäisellä kierroksella 0
                luku = Console.ReadLine();
            }
            Console.WriteLine("Lukujen summa on " + dSumma.ToString());
            Console.WriteLine();
            Console.Write("Paina enter lopettaaksesi!");
            Console.ReadLine();
        }
    }
}
