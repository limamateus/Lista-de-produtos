using System;
using System.Collections.Generic;
using Fixa_de_Funcionarios.Entites;
using System.Globalization;

namespace Fixa_de_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();


            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= n; i++)
            {
                Console.Write("Common, used or imported (c/u/i)?");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (resp == 'c')
                {
                    list.Add( new Product(name, price));
                }
                else if (resp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());

                    list.Add (new UsedProduct(name, price, manufacture));

                }else if (resp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFee));

                }

                              

            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }



        }
    }
}
