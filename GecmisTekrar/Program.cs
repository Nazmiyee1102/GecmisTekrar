using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GecmisTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen iki basamaklı bir sayı giriniz.");
            string s = Console.ReadLine();
            if (s.Count() == 2)
            {
                int sayi = int.Parse(s);
                SayiToYazi(sayi);
            }
            else
            {
                Console.WriteLine("Girilen sayı iki basamaklı olmalıdır.");
                Console.ReadKey();
            }
        }

        private static void SayiToYazi(int ikiBasamakliSayi)
        {
            //32 -> otuziki
            int birlerBasamagi = ikiBasamakliSayi % 10;
            int onlarBasamagi = ikiBasamakliSayi / 10;

            string[] birler = { "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            if (birlerBasamagi == 0)
            {
                Console.WriteLine(onlar[onlarBasamagi - 1]);
            }
            else
                Console.WriteLine(onlar[onlarBasamagi - 1] + birler[birlerBasamagi - 1]);
            Console.ReadKey();
        }

        private void IkiSayininToplami()
        {
            double sayi1;
            double sayi2;

            Console.WriteLine("Lütfen bir sayı giriniz.");
            string s1 = Console.ReadLine();
            if (s1.Contains("."))
            {
                s1 = s1.Replace(".", ",");//kullanıcı eğer sayıyı 2.4 girerse 2,4 olarak değiştirir.
            }
            sayi1 = double.Parse(s1);

            Console.WriteLine("Lütfen bir sayı giriniz.");
            string s2 = Console.ReadLine();
            if (s2.Contains("."))
            {
                s2 = s2.Replace(".", ",");
            }
            sayi2 = double.Parse(s2);

            double toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            Console.ReadKey();
        }
    }
}
