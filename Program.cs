using System;
using System.Collections;

namespace BillingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Billing App");
            printBill1();
            printBill2();
            printBill3();
        }

        static void printBill1()
        {
            Console.WriteLine("PrintBill1");
            string productName = "Pen";
            int quantityPurchased = 10;
            double price = 1.1;
            double totalBill = quantityPurchased * price;
            Console.WriteLine("Total Bill: " + totalBill);
        }

        static void printBill2()
        {
            Console.WriteLine("PrintBill2");

            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter quantity purchased:");
            int quantityPurchased = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per unit:");
            double price = double.Parse(Console.ReadLine());

            double totalBill = quantityPurchased * price;
            Console.WriteLine("Total Bill: " + totalBill);
        }

        static void printBill3()
        {
            Console.WriteLine("PrintBill3");

            Console.WriteLine("Enter the number of products:");
            int numberOfProducts = int.Parse(Console.ReadLine());

            ArrayList totalBills = new ArrayList();

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}:");

                Console.WriteLine("Enter product name:");
                string productName = Console.ReadLine();

                Console.WriteLine("Enter quantity purchased:");
                int quantityPurchased = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter price per unit:");
                double price = double.Parse(Console.ReadLine());

                double totalBill = quantityPurchased * price;
                totalBills.Add(totalBill);

                Console.WriteLine($"Total Bill for {productName}: " + totalBill);
            }

            Console.WriteLine("Total Bills for all products:");
            foreach (double bill in totalBills)
            {
                int billno = 1;
                Console.WriteLine("Bill No "+billno+1+" :" + bill);
            }
        }
    }
}


