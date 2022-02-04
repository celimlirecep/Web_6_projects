using System;

namespace Proje_10_Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 5;
            void Topla()
            {
              
                int b = 10;
                Console.WriteLine(a+b);
            }
           // Topla();

           // yaz();
            void yaz()
            {
                
                Console.WriteLine("merhaba wissen");
            }

            int c = 4;
            int d = 9;

           // sum(c, d);
            void sum(int a,int b)
            {
                Console.WriteLine(a+b);
            }

            //yaz2("recep");
            void yaz2(string isim)
            {
                Console.WriteLine($"merhaba {isim}");
            }*/
            /*
                        sum2();
                        void sum2()
                        {
                            int num1;
                            int num2;
                            
                            Console.WriteLine(num1+num2);

                        }*/

            
           
            int num1 = 0, num2 = 0;
            MathOperator("*");
            void MathOperator(string islem)
            {
                Console.Write("enter your number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("enter your number: ");
                num2 = int.Parse(Console.ReadLine());

                switch (islem)
                {
                    case "+": Console.WriteLine(num1 + num2); ; break;
                    case "-": Console.WriteLine(num1 - num2); break;
                    case "*": Console.WriteLine(num1 * num2); break;
                    case "/": Console.WriteLine(num1 / num2); break;
                    default:
                        Console.WriteLine("error parameters!!!");
                        break;
                }

            }
           



            Console.ReadLine();
        }
    }
}
