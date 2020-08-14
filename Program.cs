using System;

namespace Yildiz_Yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {


            string yildiz = "*";

            Console.WriteLine("yükseklik giriniz:"); 
            int yükseklik = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < yükseklik; i++) 
            {
                Console.WriteLine(yildiz);
                yildiz += "*";
            }


            /*for (int i = 0; i < yükseklik; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {


            //        Console.Write(yildiz);
            //    }
            //    Console.WriteLine('\n');

            } */
        }
    }
}
