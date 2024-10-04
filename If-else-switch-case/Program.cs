using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Manavdaki Fiyatları  belirttik
            Console.WriteLine("ASPAVA manavına hoşgeldiniz.");
            Console.WriteLine("Elma 2TL");
            Console.WriteLine("Armut 3TL");
            Console.WriteLine("Çilek 2TL");
            Console.WriteLine("Muz 3TL");
            Console.WriteLine("Diğer bütün meyveler 4 TL");
            Console.Write("Hangi meyveyi satın almak istersiniz ? (Elma/Armut/Çilek/Muz/Diğer) :");
            string secim=Console.ReadLine();
            //Manavdan alınacak meyvenin fiyatını belirledik

            if (secim=="Elma")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2 TL");
            }
            else if(secim=="Armut")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3 TL");
            }
            else if (secim == "Çilek")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2 TL");
            }
            else if (secim == "Muz")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3 TL");
            }
            else
            {
                Console.WriteLine("Seçtiğiniz meyve 4 TL");
            }
            Console.ReadLine();
            //ysadhasda
            //sdfdflsdf
        }
    }
}
