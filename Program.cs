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
        public static void bekeres()
        {
            Console.WriteLine("kérem a személyi azonosítód első 10 számjegyét: ");
            tizszam[0] = Convert.ToInt16(Console.ReadLine());
        }
        public static void kiiratas() 
        { 
            int szam = tizszam[0];
            int kor = 
            if (szam == )
            {
                Console.WriteLine("Maga egy férfi");
            }
            else 
            { 
                Console.WriteLine("Maga egy Nő"); 
            }
            DateTime
            Console.WriteLine("$ magának a {} a születési sorszáma");
            Console.WriteLine("$ magának a {kor}. születés napja van ebben az évben");
        }
        static void Main(string[] args)
        {
            bekeres();
            kiiratas(); 
        }
    }
}
