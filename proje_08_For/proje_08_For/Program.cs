using System;

namespace proje_08_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int sum = 0;
              for (int i = 1; i < 11; i+=2)
              {
                  *//*if (i%2==0)
                  {
                      Console.WriteLine($"i degeri: {i}");
                      sum += i;

                  }*//*

                  Console.WriteLine($"i degeri: {i}");
                  sum += i;
              }
              Console.WriteLine( $"sum: {sum}");*/

            // 1 100 arasindaki asal sayiler
            //  bool deger = false;

            /*for (int i = 2; i < 101; i++)
            {
                for (int j = i-1; j >1; j--)
                {
                    if (i%j==0 )
                    {
                        deger = true;
                        break;
                    }
                }

                if(!deger)
                    {
                    Console.WriteLine(i);
                }
                deger = false;
            }*/

            // 1 100 arasında 5 e ve 7 ye tam bölünemeyneler
            /*
                        for (int i = 1; i < 101; i++)
                        {
                            if (i%5==0 && i%7==0)
                            {
                                Console.WriteLine(i);
                            }

                        }*/

            /* for (int i = 1; i < 6; i++)
             {
                 for (int j = 1; j < 6; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();

             }*/


            /*      int yourNumber=0;
                  int comNumber=0;
                  do
                  {
                      Console.Write("enter your number: ");
                       yourNumber = int.Parse(Console.ReadLine());
                      Random rastgele = new Random();
                       comNumber = rastgele.Next(1, 10);
                      Console.WriteLine($"your number:{yourNumber}  computer number:{comNumber} ");

                  } while (yourNumber != comNumber);*/

            //çarpım tablosu

            /* for (int i = 1; i <11 ; i++)
             {
                 for (int j = 1; j < 11; j++)
                 {
                     Console.Write($" {j*i}\t");

                 }
                 Console.WriteLine();
             }

             //klavye 3 adet girilen sayıdan en büyük sayiyi ekrana yazdirİ;


 */



            /*  int bigNUmber = 0;
              int sayac = 1;
              while (sayac!=4)
              {
                  sayac++;
                  Console.Write($"{sayac-1}. sayiyi giriniz:");
                  int userNumber = int.Parse(Console.ReadLine());
                  if (bigNUmber < userNumber)
                  {
                      bigNUmber = userNumber;
                  }

              }
              Console.WriteLine("en büyük sayiniz: " +bigNUmber);*/

            int a = 5;
            a =+ 5;
            Console.WriteLine(a);


            Console.ReadLine();
        }
    }
}
