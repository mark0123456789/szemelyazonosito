using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace személyazonosító
{
    internal class Program
    {
        static string GetGender(string azonosito)
        {
            int firstDigit = int.Parse(azonosito[0].ToString());
            return firstDigit == 1 || firstDigit == 3 ? "férfi" : "nő";
        }

        static DateTime GetBirthDate(string azonosito)
        {
            int yearPrefix = int.Parse(azonosito[0].ToString()) < 3 ? 1900 : 2000;
            int year = yearPrefix + int.Parse(azonosito.Substring(1, 2));
            int month = int.Parse(azonosito.Substring(3, 2));
            int day = int.Parse(azonosito.Substring(5, 2));
            return new DateTime(year, month, day);
        }


        static int GetBirthOrder(string azonosito)
        {
            return int.Parse(azonosito.Substring(7, 3));
        }

  
        static int GetAge(DateTime birthDate)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - birthDate.Year;
        }

    
        static string CalculateChecksum(string azonosito)
        {
            int[] weights = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                total += int.Parse(azonosito[i].ToString()) * weights[i];
            }

            int remainder = total % 11;
            return remainder == 10 ? "hibás a születési sorszám" : remainder.ToString();
        }

        static void Main()
        {
            Console.Write("Adja meg az első személyazonosító jel első 10 jegyét: ");
            string azonosito1 = Console.ReadLine();

            Console.WriteLine("Nem: " + GetGender(azonosito1));

           
            Console.WriteLine("Születési sorszám: " + GetBirthOrder(azonosito1));

            
            DateTime birthDate1 = GetBirthDate(azonosito1);
            Console.WriteLine("Ebben az évben betöltött életkor: " + GetAge(birthDate1));


            Console.Write("Adja meg a második személyazonosító jel első 10 jegyét: ");
            string azonosito2 = Console.ReadLine();

 
            DateTime birthDate2 = GetBirthDate(azonosito2);
            if (birthDate1 < birthDate2 || (birthDate1 == birthDate2 && GetBirthOrder(azonosito1) < GetBirthOrder(azonosito2)))
            {
                Console.WriteLine("Az első személy idősebb.");
            }
            else
            {
                Console.WriteLine("A második személy idősebb.");
            }

            int ageDifference = Math.Abs(birthDate1.Year - birthDate2.Year);
            Console.WriteLine("Születési évek közötti különbség: " + ageDifference);


            string checksum = CalculateChecksum(azonosito2);
            if (checksum == "hibás a születési sorszám")
            {
                Console.WriteLine(checksum);
            }
            else
            {
                Console.WriteLine("A teljes személyazonosító jel: " + azonosito2 + checksum);
            }
        }
    }
}
