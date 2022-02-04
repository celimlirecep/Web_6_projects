using System;

namespace proje_11_method_example_2
{
    class Program
    {
        static int enBuyuk(int[] sayilar)
        {
            int enB = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enB)
                {
                    enB = sayilar[i];
                    
                }
            }
            return enB;
        }
        static double alan(int) 
        static void Main(string[] args)
        {
            /*// gönderilen 2 sayidan hangisi daha büyük bulan program


            int[] sayilar = { 15, 76,87 ,1,465};
            Console.WriteLine(enBuyuk(sayilar));
            Console.ReadLine();


        }*/

        //daienin alanını bulan pi bazen 3 bazende 3,14 olan kodu yazin

    }
}
