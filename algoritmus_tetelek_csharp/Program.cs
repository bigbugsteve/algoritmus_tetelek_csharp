using System;


namespace Proj_02
{
    class Log
    {

        //  Adott egy N>0 elemű RENDEZETT sorozat és egy keresett elem(Z). A sorozat elemeit az A[1..N] tömbben tároljuk.Olyan algoritmust kell írni amely eldönti, hogy van- e(Z) elem a sorozatban és ha van hányadik.Az eljárás során megkeressük a sorozat felét s kihasználjuk azt, hogy tudjuk a rendezettség miatt a keresett elem a felezéspont előtt vagy után van.Ezután tovább felezzük az így kapott részsorozatot addig amíg megtaláljuk a keresett elemet vagy, vagy összeért a felezett sorozat alsó és felső határa.
        //  Szokás az eljárást intervallum felezéses módszernek is nevezni.

        //  Bemenet: A[1..N] Rendezett a sorozat, Z
        //  Kimenet: Sorsz                      // a Z elem sorszáma- ha van
        //  Algoritmus:

        //      AH:=1	:	FH:=N               // a sorozat alsó határa-AH  felső határa-FH
        //      Ciklus

        //          i:= EGÉSZRÉSZ((AH+FH)/2)	//  az egészrész függvény egy tört 
        //                                      //  egészrészét adja
        //		    Ha(A[i]<Z) akkor AH:=i+1
        //		    Ha(A[i]>Z) akkor FH:=i-1 
        //      amíg AH<=FH és A[i] <>Z
        //      Ha(AH<=FH) akkor SORSZ:=i
        //  Algoritmus vége.


        public static int BinarisKeres(int[] tomb, int keresettertek)
        {
            int eleje = 0;
            int vege = tomb.Length; // 13

            while (eleje <= vege)
            {

                int i = (eleje + vege) / 2; // első körben 7
                Console.WriteLine("i értéke: {0}", i);
                Console.WriteLine("eleje értéke: {1}", eleje);
                //if(i == vege) return -1;
                if (tomb[i] == keresettertek) return i;

                else if (tomb[i] < keresettertek)
                {
                    eleje = i + 1;
                }
                else if (tomb[i] > keresettertek)
                {
                    vege = i - 1;
                }
            }
            Console.WriteLine("eleje értéke a while ciklus után: {0}", eleje);

            return -1;
        }

        //rekurzív implementáció
        public static int BinarisKeresRekurziv(int[] tomb, int keresettertek, int eleje, int vege)
        {
            int mid = eleje + vege / 2;
            if (vege < 1)
            {
                return -1;
            }
            if (tomb[mid] == keresettertek)
            {
                return mid;
            }
            if (tomb[mid] > keresettertek)
                return BinarisKeresRekurziv(tomb, keresettertek, eleje, mid - 1);

            return BinarisKeresRekurziv(tomb, keresettertek, mid + 1, vege);
        }

        static void Main(string[] args)
        {


            var tomb = new int[] { 0, 0, 1, 2, 2, 2, 3, 1, 4, 5, 6, 8, 9 };

            var index = BinarisKeres(tomb, 8);  // 4
            int index2 = BinarisKeresRekurziv(tomb, 8, 0, tomb.Length);

            if (index == -1)
            {
                Console.WriteLine("A keresett szám nincs a tömbben");
            }
            else
            {
                Console.WriteLine("A nyolcas indexe: {0}", index);
                Console.WriteLine("Az egyes indexe: {0}", index2);
            }

            Console.ReadKey();
        }
    }
}
