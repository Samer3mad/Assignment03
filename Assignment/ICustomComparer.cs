using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface ICustomComparer
    {
        bool Compare(int x, int y);
    }

    internal class AscComparer : ICustomComparer
    {
        public bool Compare(int x, int y)
        {
            return x > y;
        }
    }

    internal class DescComparer : ICustomComparer
    {
        public bool Compare(int x, int y)
        {
            return x < y;
        }
    }
}
