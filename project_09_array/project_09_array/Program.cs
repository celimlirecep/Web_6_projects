using System;

namespace project_09_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   int[] firsArray = { 40, 50, 60 };
               for (int i = 0; i < 3; i++)
               {
                   Console.WriteLine(firsArray[i]);
               }
               string[] firstStringArray = { "adamm","madam" };
               Console.WriteLine(firstStringArray[0]);*/


            /*
                         Random rgl = new Random();
                         int[] sayiler= new int[10];
                         for (int i = 0; i < 10; i++)
                         {
                             sayiler[i] = rgl.Next(1, 100);

                         }

                        foreach (var sayi in sayiler)
                        {
                            Console.WriteLine(sayi);
                        }*/

            //1-100 arasında rasgele sayi üretsin
            //kullanıcıdan bu sayiyi tahmin etmesini isteyelim bilirse tebrik bilemesse kaybettin
            //1. tahminde bilinirse  sırayla : 50 - 40 - 30 -20 -10
            // kullanıcıdan oyunu tekrar oynayıp oynmak istemediği sorulacak
            Random rnd = new Random();
            int deskopNumber = 0;
            int sayac = 1;
            int[] yourEstimate = new int[5];

            int[] deskopEstimate = new int[5];
            int userNumber = 0;
            do
            {
                 deskopNumber = rnd.Next(1, 10);
                Console.WriteLine(deskopNumber);
                deskopEstimate[sayac-1] = deskopNumber;
                Console.Write("please enter your number (Between 1 and 10) :   ");
                 userNumber = int.Parse(Console.ReadLine());
                  yourEstimate[sayac-1] = userNumber;
                
                if (userNumber == deskopNumber)
                {
                    Console.WriteLine("HELAL OLSUN DAYI OGLI!!!");
                    break;
                }
                else
                {
                    Console.WriteLine($"BIDAHA DENE DAYI OGLI [KALAN DENEME SAYIN:    {5 - sayac} ");
                }
                sayac++;
                Console.ReadLine();
                Console.Clear();
            } while (sayac != 6);
            Console.Write("your estimate   :");
            foreach (var item in yourEstimate)
            {
                Console.Write(" "+item);
            }
            Console.Write("\ndeskop estimate: ");
            foreach (var item in deskopEstimate)
            {
                Console.Write(" " + item);
            }
            
                Console.WriteLine($"\nyour score = {(6 - sayac) * 10} ");
            
           

            
            Console.ReadLine();
        }
    }
}
