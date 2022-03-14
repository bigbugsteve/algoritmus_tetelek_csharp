using System;


namespace Proj_02
{
    class Megszamlalas
    {
        
        static void Main(string[] args)
        {
            // ===================================================================================================================================================================
            //  Megszámlálás tétele
            //  Adott egy N > 0 elemű sorozat, s egy a sorozat tagjain értelmezett T tulajdonság.Olyan algoritmust kell írni amely megszámlálja a T tulajdonságú elemeket.
            //      Bemenet: A[1..N], T tulajdonság
            //      Kimenet: DB / a Ttul elemek  száma
            //          Algoritmus:
            //	            DB:= 0
            //              Ciklus i := 1 - től N - ig
            //                  Ha(A[i] Ttulajdonságú) akkor DB:= DB + 1
            //              Ciklus vége.
            //          Algoritmus vége.

            int[] A = { 1, 1, 2, 2, 2, 3, 3, 4, 5, 5, };
            int keresett = 2;
            int db = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (keresett == A[i])
                {
                    db++;
                }
            }

            //            Console.WriteLine(db + " db. van belőle.");

            Console.ReadKey();
        }
    }
}
