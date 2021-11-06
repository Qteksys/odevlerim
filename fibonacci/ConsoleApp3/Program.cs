using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
        Bas:
            Console.WriteLine("Fibonacci dizisi programına hoşgeldiniz !");
            Console.WriteLine("Dizinin kaç elemanını görmek istersiniz ?\n(en fazla 46 eleman)");
            int deger = Convert.ToInt16(Console.ReadLine());
            
            if (deger<47 && deger>0)
            {
                Console.WriteLine("İşte diziniz !");
                Fibonacci(deger);
                Bas2:
                Console.WriteLine("Bu değerleri toplamak ister misiniz ?");
                Console.WriteLine(" (a)-evet \n (b)-hayır");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'a')
                {
                    Toplama(deger);
                }
                else if (cevap == 'b')
                {
                    goto Bas;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşa bastınız!");
                    goto Bas2;
                }
            }
            
            else
            {
                Console.WriteLine("Çok büyük yada küçük değer verdiniz! \n Yeniden deneyin!");
            }
            
            goto Bas;
        }
        static void Fibonacci(int deger)
        {

            int sayi1 = 1;
            int sayi2 = 1;
            int i, sayi3;
           
            Console.Write(" " + sayi1 + "\n ");
            Console.Write(sayi2 + "\n ");
            for (i = 3; i <= deger; i++)
            {
                sayi3 = sayi1 + sayi2;

                Console.Write(sayi3 + "\n ");

                sayi1 = sayi2;
                sayi2 = sayi3;
            }
           

      
        }
       static void Toplama(int deger)
        {
            int sayi1 = 0;
            int sayi2 = 1;
            int sayi3;
            
            for (int i = 2; i <= deger; i++)
            {
                sayi3 = sayi1 + sayi2;

               

                sayi1 = sayi2;
                sayi2 = sayi3;
                int toplam = sayi1 + sayi2 + sayi3-1;
                if (i==deger)
                {
                    Console.WriteLine("sonucunuz="+toplam);
                }
                else
                {

                }
                
            }
           
                
            
        }

        
    } 

}
