using System;
using System.Collections.Generic;
using System.Text;

namespace CatLib
{
    public class Cat : BaseCat, ICat
    {
        private int _weasel;

        public string CatName { get; set; }
        public string BreedCat { get; set; }

        public int Weasel { get { return _weasel; } }

        public void IncreaseWeasel(int step)
        {
            _weasel += step;
        }

        public void DecreaseWeasel(int step)
        {
            if (_weasel - step >= 0)
            {
                _weasel -= step;
            }
        }
    }
}

