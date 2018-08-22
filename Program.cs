using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            (string product, double amount, int quantity) hammer = ("Hammer", 19.99, 25);
            (string product, double amount, int quantity) nails = ("Nails", 7.99, 100);
            (string product, double amount, int quantity) nailGun = ("Nailgun", 189.99, 1);
            (string product, double amount, int quantity) bandaids = ("Bandaids", 6.72, 250);
            (string product, double amount, int quantity) staples = ("Staples", 3.98, 50);
            transactions.Add(hammer);
            transactions.Add(nails);
            transactions.Add(nailGun);
            transactions.Add(bandaids);
            transactions.Add(staples);
            int TotalProductsSold = 0;
            double TotalRevenue = 0;

            foreach ((string product, double amount, int quantity) item in transactions)
            {
                TotalProductsSold += item.quantity;
                TotalRevenue += item.quantity * item.amount;
            }
            Console.WriteLine($"We sold {TotalProductsSold} products for a revenue of {TotalRevenue}");
        }
    }
}
