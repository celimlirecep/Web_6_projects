using System;

namespace Proje_11_Method_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan sayi iste bilgisayarınkiyle karsilastir methodlar kullanarak 
            //puanlama sistemi olucak
            //hata mesajlari yazdirilicak
            
            int sayac = 0;
            int deskopEstimate = 0;
            int userEstimate = 0;
            bool oyunTekrari = true;
            string oyunTekrarDegeri = "";
            int userNumbers = 1;
            int rastgele = 1;


            int userNumber()
            {
                Console.Write("please enter your number: ");
                userNumbers = int.Parse(Console.ReadLine());
                return userNumbers;
            }
            int deskopNumber()
            {
                Random rgl = new Random();
                rastgele = rgl.Next(1,100);
                return rastgele;
            }
            void karsilastirma(int sayac1)
            {
                if (userEstimate!=deskopEstimate && sayac1<=4)
                {
                    Console.WriteLine($"your estimate is wrong/ your remaining right: {4-sayac1}" );
                    sayac++;
                }
                else if (userEstimate != deskopEstimate && sayac1>4)
                {
                    Console.WriteLine($"your all of estimate is wrong/ your remaining right: {4-sayac1}");
                    //sayac = 6;
                }
                else
                {
                    Console.WriteLine($"your estimate is true/ you found it in the {sayac1+1}");
                    sayac++;
                }

                  if (sayac==5)
                  {
                      sayac = 6;
                  }
                  
                Console.WriteLine("fonksiyonnn -------------------------------:   "+sayac);
            }
            void oyun()
            {
                do
                {
                    deskopEstimate = deskopNumber();
                    Console.WriteLine("deskop numarsı: " + deskopEstimate);
                    userEstimate = userNumber();
                    karsilastirma(sayac);
                    Console.WriteLine("sayac-------------------------------------:    " + sayac);

                } while (sayac < 5 && userEstimate != deskopEstimate);
                Console.WriteLine($"your score: {(6-sayac)*10}" );
                sayac = 0;
            }
            do
            {
                oyun();
                if (oyunTekrari)
                {
                    Console.WriteLine("can you return game enter: + ");
                     oyunTekrarDegeri=Console.ReadLine();
                }
                
            } while (oyunTekrarDegeri=="+");
        }
    }
}
