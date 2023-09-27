//Solution 3 of Assignment 5.
using System;
namespace Assignment_5
{
    class Solution_3
    {
        static void Main()
        {
            //user input for sales details
            Console.Write("Enter Sales No: ");
            int salesNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Product No: ");
            int productNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            Console.Write("Enter Date of Sale (yyyy-MM-dd): ");
            DateTime dateofSale = DateTime.Parse(Console.ReadLine());

            // Creating a Saledetails object with user input
            Saledetails sale1 = new Saledetails(salesNo, productNo, price, dateofSale, qty);

            // show the data
            sale1.showData();
            Console.Read();

        }
    }
    class Saledetails
    {
        public int Salesno;
        public int Productno;
        public double Price;
        public DateTime dateofSale;
        public int Qty;
        public double TotalAmount;


         public void sales()
        {
            this.TotalAmount = this.Qty * this.Price;
        }
        public Saledetails(int salesNo, int productNo, double price, DateTime DateOfSale, int qty)
        {
            this.Salesno = salesNo;
            this.Productno = productNo;
            this.Price = price;
            this.dateofSale = DateOfSale;
            this.Qty = qty;

            sales();
        }
        public void showData()
        {
            Console.WriteLine($"Sales No: {this.Salesno}");
            Console.WriteLine($"Product No: {this.Productno}");
            Console.WriteLine($"Price: {this.Price}");
            Console.WriteLine($"Date of Sale: {this.dateofSale}");
            Console.WriteLine($"Quantity: {this.Qty}");
            Console.WriteLine($"Total Amount: {this.TotalAmount}");
        }
    }
}
