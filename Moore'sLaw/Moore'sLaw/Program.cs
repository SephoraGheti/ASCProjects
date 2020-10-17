using System;

namespace Moore_sLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXPLICATIE: IN POZA ATASATA


            Console.Write("Puterea de calcul fata de momentul dat:");
            int x = int.Parse(Console.ReadLine());
            double Timp = (Math.Log2(x) * 18) / 12;
            Console.WriteLine($"In {Timp} ani, puterea de calcul va deveni de {x} mai mare, ramanand la acelasi pret.");


        }
    }
}
