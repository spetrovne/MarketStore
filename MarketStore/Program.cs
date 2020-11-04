using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var bronzeCard = new Bronze("Stefan Panchev",0);
            var goldCard = new Gold("Sasho Roman",1500);
            var silverCard = new Silver("Nikolаоs Citiridis",600);

            var purchaseWithBtonze = new Purchase(150, bronzeCard);
            var purchaseWithSilver = new Purchase(850, silverCard);
            var purchaseWithGold = new Purchase(1300, goldCard);

            Console.WriteLine(purchaseWithBtonze.ToString());
            Console.WriteLine(purchaseWithSilver.ToString());
            Console.WriteLine(purchaseWithGold.ToString());
        }
    }
}
