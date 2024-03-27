using System;

namespace Fckn_Nehez_Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia!!!");

            int bekertszam = int.Parse(Console.ReadLine());

            for (int i = 0; i < bekertszam; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
