﻿//using System;


//namespace Proj_02
//{
//    class MetszetUnio
//    {
//        static void Main(string[] args)
//        {

//            int[] A_tomb = new int[10] { 13, 28, 43, 37, 10, 5, 8, 99, 101, 2 };
//            int[] B_tomb = new int[5] { 6, 43, 37, 10, 88 };
//            int i, j, cdb = 0;
//            int[] C_tomb = new int[15];

//            Console.WriteLine("Az eredeti tömbök:");

//            Console.WriteLine("A tömb: ");
//            for (i = 0; i < 10; i++)
//            {
//                Console.Write("{0}\t", A_tomb[i]);
//            }

//            Console.WriteLine("\nB tömb:");
//            for (j = 0; j < 5; j++)
//            {
//                Console.Write("{0}\t", B_tomb[j]);
//            }

//            // ===================================================================================================================================================================
//            // METSZETKÉPZÉS TÉTELE
//            //  Rendelkezésre áll egy N> 0 és egy M > 0 elemű halmaz  az A[1..N] és B[1..M] vektorokban tárolva. Készítsük el a két halmaz metszetét a C[] vektorba!
//            //  Megoldás: vegyük egyenként az A[1..N] elemeit és nézzük meg, hogy találunk - e a B[1..M] elemei közt vele megegyezőt, s ha találunk tegyük ezt az elemet a C[]-be!

//            //    Bemenet: A[1..N], B[1..M]
//            //    Kimenet: C[]
//            //    Algoritmus :
//            //		Cdb:= 0
//            //        Ciklus i = 1 - től N - ig
//            //            j:= 1
//            //            Ciklus amíg j <= M és A[i] <> B[j]
//            //                j:= j + 1
//            //            Ciklus vége
//            //            Ha(j <= M) akkor Cdb:= Cdb + 1    :   C[Cdb]:= A[i]
//            //        Ciklus vége.
//            //    Algoritmus vége.

//            // metszet képzés
//            for (i = 0; i < 10; i++)
//            {
//                j = 0;
//                while (j < 5 && A_tomb[i] != B_tomb[j])
//                    j++;
//                if (j < 5) { C_tomb[cdb] = A_tomb[i]; cdb++; }
//            }

//            // metszet kiírása
//            Console.WriteLine("\nA metszet tömb elemei:");
//            for (j = 0; j < cdb; j++)
//            {
//                Console.Write("{0}\t", C_tomb[j]);
//            }

//            // ===================================================================================================================================================================
//            // UNIOKÉPZÉS TÉTELE
//            //  Adottak az N > 0 és egy M > 0 elemű halmazok az A[1..N] és B[1..M] vektorokban tárolva. Készítsük el a két halmaz egyesítettjét(unióját) C[] vektorba!
//            //  Megoldás: vegyük az A[1..N] elemeit egyenként és pakoljuk be őket a C[1..M]-be.Ezután a feladat már szinte ugyanaz mint az előbbi metszetképzés azzal a különbséggel, hogy most akkor rakjuk be a C[]-be a B[] soron következő elemét ha nem találtunk vele megegyezőt A[]-ban.

//            //  Bemenet: A[1..N], B[1..M]
//            //  Kimenet: C[1..cdb] / egyesített  sorozat

//            //  Algoritmus:
//            //      Ciklus i: = 1 – től N-ig
//            //          C[i]:= A[i]
//            //      Ciklus vége

//            //      cdb:= N
//            //      Ciklus j = 1 - től M - ig
//            //          i:= 1
//            //          Ciklus amíg i <= N és A[i] <> B[j]
//            //              i:= i + 1
//            //          Ciklus vége.
//            //          Ha(i > N)      akkor cdb:= cdb + 1
//            //              C[cdb]:= B[j]
//            //          Elágazás vége.
//            //      Ciklus vége.
//            //  Algoritmus vége.


//            // unio képzés
//            for (i = 0; i < 10; i++)
//            {
//                C_tomb[i] = A_tomb[i];
//            }
//            cdb = 10;
//            for (j = 0; j < 5; j++)
//            {
//                i = 0;
//                while (i < 10 && A_tomb[i] != B_tomb[j])
//                    i++;
//                if (i > 9) { C_tomb[cdb] = B_tomb[j]; cdb++; }
//            }

//            // unio kiírás
//            Console.WriteLine("\nAz unio tömb:");
//            for (j = 0; j < cdb; j++)
//            {
//                Console.Write("{0}\t", C_tomb[j]);
//            }

//            // ===================================================================================================================================================================
//            //  Megszámlálás tétele
//            //  Adott egy N > 0 elemű sorozat, s egy a sorozat tagjain értelmezett T tulajdonság.Olyan algoritmust kell írni amely megszámlálja a T tulajdonságú elemeket.
//            //      Bemenet: A[1..N], T tulajdonság
//            //      Kimenet: DB / a Ttul elemek  száma
//            //          Algoritmus:
//            //	            DB:= 0
//            //              Ciklus i := 1 - től N - ig
//            //                  Ha(A[i] Ttulajdonságú) akkor DB:= DB + 1
//            //              Ciklus vége.
//            //          Algoritmus vége.

//            int[] A = { 1, 1, 2, 2, 2, 3, 3, 4, 5, 5, };
//            int keresett = 2;
//            int db = 0;

//            for (i = 0; i < A.Length; i++)
//            {
//                if (keresett == A[i])
//                {
//                    db++;
//                }
//            }

//            Console.WriteLine(db + " db. van belőle.");
            

//            Console.ReadKey();
//        }
//    }
//}