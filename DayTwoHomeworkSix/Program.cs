using System;

namespace DayTwoHomeworkSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product product1 = new Product();
            product1.ProductID = 1;
            product1.ProductName = "Laptop";
            product1.ProductDetail = "Asus laptop";

            Product product2 = new Product();
            product2.ProductID = 2;
            product2.ProductName = "Çanta";
            product2.ProductDetail = "Spor çantası";

            Product product3 = new Product();
            product3.ProductID = 3;
            product3.ProductName = "Ayakkabı";
            product3.ProductDetail = "Nike spor ayakkabı";

            Product[] products = new Product[] { product1, product2, product3 };

            //for loop
            Console.WriteLine("----------------------\nFor Loop\n------------------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün adı : " + products[i].ProductName + "\n" + "Ürün detayı : " + products[i].ProductDetail + "\n");
            }

            //foreach loop
            Console.WriteLine("----------------------\nForeach Loop\n---------------------------------");

            foreach (var product in products)
            {
                Console.WriteLine("Ürün adı : " + product.ProductName + "\n" + "Ürün detayı : " + product.ProductDetail + "\n");
            }

            //while loop
            Console.WriteLine("----------------------\nWhile Loop\n---------------------------------");

            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine("Ürün adı : " + products[j].ProductName + "\n" + "Ürün detayı : " + products[j].ProductDetail + "\n");
                j++;
            }
        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
    }
}
