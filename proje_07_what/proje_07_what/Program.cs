using System;

namespace proje_07_what
{
    class Program
      
    {
        static void Main(string[] args)
        {
            Console.Write("birinci urunun fiyatini giriniz: ");
            int urun1=int.Parse( Console.ReadLine());
            Console.Write("ikinci urunun fiyatini giriniz: ");
            int urun2 = int.Parse(Console.ReadLine());
            double indirimsizTop = urun1 + urun2;
            double indirimliTop = urun1 + urun2 * 0.65;// 200ün altındaysa indirimliyi  boşuna hesaplama diyebilirdik.
            int kargoUcreti = 25;
            Console.WriteLine();
            double odenecekToplam=0;

            if (indirimsizTop > 200 && indirimliTop>250)
            {
               
                    kargoUcreti = 0;
                
            }
            else
            {
                indirimliTop = indirimsizTop;
            }
            odenecekToplam = indirimliTop + kargoUcreti;
            Console.WriteLine($"genel tutar:{indirimsizTop}, indirimli tutar: {indirimliTop}, kargo bedeli: {kargoUcreti}, ödenecek en son toplam: {odenecekToplam} ");
            Console.ReadLine();
        }
    }
}
