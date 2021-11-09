using System;

namespace _2.gün_ödevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.productName = "comb";
            product1.productId = "010010";
            product1.productPrice = 10;
            product1.productType = "home stuff";

            Products product2 = new Products();
            product2.productName = "parfume";
            product2.productId = "010011";
            product2.productPrice = 1000;
            product2.productType = "cosmetic";

            Products product3 = new Products();
            product3.productName = "light";
            product3.productId = "010012";
            product3.productPrice = 60;
            product3.productType = "home stuff";

            Products product4 = new Products();
            product4.productName = "chair";
            product4.productId = "010013";
            product4.productPrice = 200;
            product4.productType = "home stuff";

            Products product5 = new Products();
            product5.productName = "charge machine";
            product5.productId = "010014";
            product5.productPrice = 25;
            product5.productType = "tech";

            Products[] products = new Products[] { product1, product2, product3, product4, product5 };

            foreach (var pdt in products)
            {
                Console.WriteLine(pdt.productName);
            }

            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine(products[j].productType);
            }

            int i = 0;
            while (i < products.Length)
            {
                Console.WriteLine(products[i].productId);
                i++;
            }

        }

    }
}
