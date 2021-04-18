using System;

namespace CatLib
{
    public abstract class BaseCat
    {
        protected int FeedQuantity = 0;
        public int Food { get { return FeedQuantity; } }
        public void FeedTheCat(string foodName, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("You can not get food back!");
            }

            FeedQuantity += quantity;
        }
    }
}
