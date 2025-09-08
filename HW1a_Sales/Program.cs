// HW1a Sales Total

// Your Name: Cadence Walton
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product;
            int quantity;
            double price, subtotal, salesTax, total;
            const double taxRate = .085;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            product = Console.ReadLine();

            Console.WriteLine($"How many {product}s do you want to buy?");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"What is the price for each {product}?");
            price = Convert.ToDouble(Console.ReadLine());

            subtotal = price * quantity;
            salesTax = subtotal * taxRate;
            total = subtotal + salesTax;

            Console.WriteLine($"\tYour subtotal for your bill is {subtotal.ToString("C2")}.\n\tYour sales tax for your bill is {salesTax.ToString("C2")}.\n\tYour total for your bill is {total.ToString("C2")}.");
            Console.ReadKey();
        }
    }
}
