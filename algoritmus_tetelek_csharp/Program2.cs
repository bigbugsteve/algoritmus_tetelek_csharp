using System;


namespace Proj_02
{
    class Log
    {
        public static int  BinarisKeres(int[] tomb, int keresettertek)
        {
            int eleje = 0;
            int vege = tomb.Length; // 13

            while (eleje <= vege)
            {
                // 13 hosszú a tömb
                // 

                int i = (eleje + vege) / 2; // 7

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
            } else
            {
                Console.WriteLine("A nyolcas indexe: {0}", index);
                Console.WriteLine("Az egyes indexe: {0}", index2);
            }

            Console.ReadKey();
        }
    }
}
