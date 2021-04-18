using System;
using System.Collections.Generic;
using System.Text;

namespace CatLib
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICat cat = new Cat();
            cat.CatName = "Masyanya";
            cat.BreedCat = "Wireless";
            cat.FeedTheCat("Wiskas", 1);
            cat.IncreaseWeasel(10);
            cat.DecreaseWeasel(1);

            Console.WriteLine($"Cat: {cat.CatName} Breed: {cat.BreedCat} Weasel: {cat.Weasel} Food: {cat.Food}");
        }
    }
}

