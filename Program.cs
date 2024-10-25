using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace személyazonosító
{
    internal class Program
    {

        public static string[] tizszam = new string[2];
        public static void bekeres()
        {
            while (tizszam.Length != 10)
            {
                Console.WriteLine("kérem a személyazonosítolyának az első 10 számjegyét");
                tizszam[0] = Console.ReadLine();
            }
        }
        public static void kiiratas() 
        { 
            string Tizszam = tizszam[0];
            int nem = Convert.ToInt32(Tizszam[0]);
            int kor =  ;
            int sorszam = Convert.ToInt32(Tizszam[7]);

            if (nem  == 0%2)
            {
                Console.WriteLine("Maga egy nő ");
            }
            else 
            { 
                Console.WriteLine("Maga egy férfi "); 
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
