using System;
using System.Collections.Generic;
using System.Text;

namespace CatLib
{
    public interface ICat
    {
        string CatName { get; set; }
        string BreedCat { get; set; }
        int Weasel { get; }
        int Food { get; }
        void FeedTheCat(string foodName, int quantity);
        void DecreaseWeasel(int step);
        void IncreaseWeasel(int step);
    }
}
