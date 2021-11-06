using System;

namespace tek_mi_çift_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            tekMiciftMi(10);
        }

        private static int tekMiciftMi(int deger)
        {
            
            int sonuc = deger % 2;
            if (sonuc == 0)
            {
                Console.WriteLine("çifttir");

            }
            else
            {
                Console.WriteLine("tektir");
            }
            return deger;
        }
    }
}
