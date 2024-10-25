using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace személyazonosító
{
    internal class Program
    {

        public static int[] tizszam = new int[2];
        public static DateTime[] evszamok;
        public static void bekeres()
        {
            Console.WriteLine("kérem a személyi azonosítód első 10 számjegyét: ");
            tizszam[0] = Convert.ToInt16(Console.ReadLine());

        }
        static void Main(string[] args)
        {
        }
    }
}
