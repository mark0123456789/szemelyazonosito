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

        // Életkor kiszámítása
        static int GetAge(DateTime birthDate)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - birthDate.Year;
        }

        // Ellenőrző szám (11. jegy) kiszámítása
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

        }
    }
}
