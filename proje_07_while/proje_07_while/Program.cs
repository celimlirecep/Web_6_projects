using System;

namespace proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*short sayac = 1;
            int sum = 0;
            while (sayac < 6)
            {
                Console.WriteLine(sayac);
                sum += sayac;
                sayac++;
            }
            Console.WriteLine("toplam : " + sum);
            Console.ReadLine();*/


            /*
                        do  
                        {
                            Console.WriteLine("HELLO WORLD");

                        } while (Console.ReadLine() != "exit") ;*/

            //kullanıcı adı ve sifre 

            /*string kullaniciAdi = "admin";
            bool sayac = false;
            int kullaniciSifresi = 123;
            int kullaniciSifresiGirilen=0;
            string kullaniciAdiGirilen="";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                if (sayac)
                {
                    Console.WriteLine("--------------hatali girdiniz-----------------");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Write(" lütfen kullanici adini ekrana giriniz: ");
                 kullaniciAdiGirilen = Console.ReadLine();
                Console.Write(" lütfen sifrenizi ekrana giriniz: ");
                 kullaniciSifresiGirilen = int.Parse(Console.ReadLine());
                sayac = true;
                
             
            } while (kullaniciAdi != kullaniciAdiGirilen || kullaniciSifresi != kullaniciSifresiGirilen);
            Console.WriteLine("wonderful you access your account!!!");
            Console.ReadLine();

            klavyeden art arda sayı girişini yaılmasını sağlayan ve girilen sayıların toplamı 1000 i geçene kadar toplam devam eeen 
            yada 10 adet sayı girilmesine devaöm eden ve sonunda toplaı sonunda ekrana yazanız
*/
            int sayac = 0;
            int sum = 0;

            while (sum<1000 && sayac<11 )
            {
                Console.WriteLine("lütfen toplanmasini istediğiniz sayilari giriniz: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
                sayac++;
                Console.WriteLine("-------------  "+sayac +"     "+ sum);
            }
            Console.WriteLine($"girilen sayıların toplami: {sum} ve yazdiginiz sayi adedi: {sayac}");
        }
    }
}
