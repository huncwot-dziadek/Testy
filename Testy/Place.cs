using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy
{
    internal class Place
    {
        public Place(int box, int number)
        {
            this.Box = box;
            this.Number = number;
        }

        public int Box { get; private set; }

        public int Number { get; private set; }

    }
}
