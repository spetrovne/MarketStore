using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {

            var bronzeCard = new Bronze(0);
            var goldCard = new Gold(1500);
            var silverCard = new Silver(600);

            var purchaseWithBtonze = new Purchase(150, bronzeCard);
            var purchaseWithSilver = new Purchase(850, silverCard);
            var purchaseWithGold = new Purchase(1300, goldCard);

            Console.WriteLine(purchaseWithBtonze.ToString());
            Console.WriteLine(purchaseWithSilver.ToString());
            Console.WriteLine(purchaseWithGold.ToString());



        }
    }
}
