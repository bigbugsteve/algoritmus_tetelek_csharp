using System;

namespace feladat
{
    class Log2
    {
        static void Main(string[] args)
        {
            int[] N = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int elso_szam = 0;
            int utolso_szam = N.Length;
            int keresett = 10;
            int i = (elso_szam + utolso_szam) / 2;

            Console.WriteLine("A keresett szám: {0}", keresett);


            while (elso_szam <= utolso_szam)
            {
                i = (elso_szam + utolso_szam) / 2;
                if (keresett <= N[i])
                {
                    utolso_szam = i - 1;
                }
                else
                {
                    elso_szam = i + 1;
                }
            }
            Console.WriteLine("Indexe {0}", i);

            Console.ReadKey();
        }
    }
}