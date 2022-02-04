using System;

namespace Proje_10_Metodlar_02
{
    class Program
    {
        static int Topla(int num1, int num2, int num3)
        {
            int sonuc=num1 + num2 + num3;
            return sonuc;
        }
        static int Topla(int num1, int num2)
        {
            int sonuc= num1 + num2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(56,112));
            Console.WriteLine(Topla(452,69,69));

           
            Console.ReadLine();

        }
    }
}
