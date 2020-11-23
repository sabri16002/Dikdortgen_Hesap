using System;

namespace Dikdortgen
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, b;
            Dikdörtgen hesap = new Dikdörtgen();
            Console.Write("Uzun Kenarı Giriniz: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kısa Kenarı Giriniz: ");
            b = Convert.ToDouble(Console.ReadLine());
            hesap.Alanheaspla(h, b);
            hesap.Cevreheaspla(h, b);
        }
    }
    class Dikdörtgen
    {
        double a, c;
        public void Alanheaspla(double h, double b)
        {
            a = h * b;
            Console.WriteLine("\nAlanı: " + a);
        }
        public void Cevreheaspla(double h, double b)
        {
            c = (h + b) * 2;
            Console.WriteLine("Çevresi: " + c);
        }
    }
}
