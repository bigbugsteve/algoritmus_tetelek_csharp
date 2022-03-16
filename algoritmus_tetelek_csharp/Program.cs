using System;


namespace Proj_02
{
    class Metszet
    {
        
        static void Main(string[] args)
        {
            int[] A_tomb = new int[10] { 13, 28, 43, 37, 10, 5, 8, 99, 101, 2 };
            int[] B_tomb = new int[5] { 6, 43, 37, 10, 88 };
            int i, j, cdb = 0;
            int[] C_tomb = new int[5];

            Console.WriteLine("Az eredeti tömbök:");

            Console.WriteLine("A tömb: ");
            for (i = 0; i < 10; i++)
                {
                    Console.Write("{0}\t", A_tomb[i]);
                }

            Console.WriteLine("\nB tömb:");
            for (j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", B_tomb[j]);
                }

            // ===================================================================================================================================================================
            // METSZETKÉPZÉS TÉTELE
            // Rendelkezésre áll egy N> 0 és egy M > 0 elemű halmaz  az A[1..N] és B[1..M] vektorokban tárolva. Készítsük el a két halmaz metszetét a C[] vektorba!
            //  Megoldás: vegyük egyenként az A[1..N] elemeit és nézzük meg, hogy találunk - e a B[1..M] elemei közt vele megegyezőt, s ha találunk tegyük ezt az elemet a C[]-be!

            //    Bemenet: A[1..N], B[1..M]
            //    Kimenet: C[]
            //    Algoritmus :
            //		Cdb:= 0
            //        Ciklus i = 1 - től N - ig
            //            j:= 1
            //            Ciklus amíg j <= M és A[i] <> B[j]
            //                j:= j + 1
            //            Ciklus vége
            //            Ha(j <= M) akkor Cdb:= Cdb + 1    :   C[Cdb]:= A[i]
            //        Ciklus vége.
            //    Algoritmus vége.

            //metszet képzés
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("i: {0}", i);
                j = 0;
                while (j < 5 && A_tomb[i] != B_tomb[j])
                    j++;
                if (j < 5) {
                    Console.WriteLine("B tömb j-edik elem: {0}", B_tomb[j]);
                    Console.WriteLine("A tömb i-edik elem: {0}", A_tomb[i]);

                    C_tomb[cdb] = A_tomb[i];
                    cdb++; 
                }
            }

            // metszet kiírása
            Console.WriteLine("\nA metszet tömb elemei:");
            for (j = 0; j < cdb; j++)
            {
                Console.Write("{0}\t", C_tomb[j]);
            }

            Console.ReadKey();
        }
    }
}
