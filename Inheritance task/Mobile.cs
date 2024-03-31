using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mobile:
//string[] SimCards field - ı var.
//Mobile classından obyekt yaranan zaman SimCardCount parametrini məcbur qəbul edir.
//SimCardCount minimum 1 maksimum 2 ola bilər.
//Bu parametr SimCards field-inin uzunluğunu təyin edir.
//AddNumber, RemoveNumber, GetNumbers methodları ilə istifadəçi nömrələrə baxa, nömrə əlavə və ya nömrənin indeksini bildirərək silə bilər.
namespace Inheritance_task
{
    internal class Mobile : Device
    {
        public string[] SimCards;
        public Mobile(double width, double height, double weight, int simcartcount) : base(width, height, weight)
        {
            if (simcartcount < 1 || simcartcount > 2)
            {
                Console.WriteLine("1 ve ya 2 sim kart daxil edin");
            }
            SimCards = new string[simcartcount];
        }
        public void AddNumber(int simindex, string simnumber)
        {
            if (0 < simindex && simindex < SimCards.Length)
            {
                SimCards[simindex] = simnumber;
            }
            else
            {
                Console.WriteLine("simindex sehfdir");
            }
        }
        public void RemoveNumber(int simindex)
        {
            if (0 < simindex && simindex < SimCards.Length)
            {
                string Removenum = SimCards[simindex];
                SimCards[simindex] = null;
                Console.WriteLine($"{Removenum} bu nomre silindi");
            }
            else
            {
                Console.WriteLine("simindex sehfdir");
            }
        }
        public void GetNumbers()
        {
            for (int i = 0; i < SimCards.Length; i++)
            {
                if (SimCards[i] != null)
                {
                    Console.WriteLine($"{i}. {SimCards[i]}");
                }
                else
                {
                    Console.WriteLine($"{i}. Nomre yoxdu");
                }
            }
        }
    }
}
