using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manavdaki Fiyatları  belirttik
            Console.WriteLine("ASPAVA manavına hoşgeldiniz.");
            Console.WriteLine("Elma 2TL");
            Console.WriteLine("Armut 3TL");
            Console.WriteLine("Çilek 2TL");
            Console.WriteLine("Muz 3TL");
            Console.WriteLine("Diğer bütün meyveler 4 TL");
            Console.Write("Hangi meyveyi satın almak istersiniz ? (Elma/Armut/Çilek/Muz/Diğer) :");
            string secim = Console.ReadLine();
            //Manavdan alınacak meyvenin fiyatını belirledik
            switch (secim)
            {
                case "Elma":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2 TL");
                    break;
                case "Armut":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3 TL");
                    break;
                case "Çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2 TL");
                    break;
                case "Muz":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3 TL");
                    break;
                default:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4 TL");
                    break;
            }
            Console.ReadLine();
        }
    }
}
