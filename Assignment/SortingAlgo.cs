using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate TResult CustomFun<in T1, in T2, out TResult>(T1 arg01, T2 arg02);
    internal class SortingAlgo<T>
    {
        public static void BubbleSort(T[] elements, CustomFun<T, T, bool> func)
        {
            if (elements is null || func is null)
                return;
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length - 1 - i; j++)
                {
                    //if ( nums[j] > nums[j + 1])
                    if (func.Invoke(elements[j], elements[j + 1]))
                        SWAP(ref elements[j], ref elements[j + 1]);
                }
            }
        }

        private static void SWAP(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    class SortingTypes
    {
        public static bool CompareGrt(int x, int y) => x > y;
        public static bool CompareGrt(string x, string y) => x.CompareTo(y) == 1;

        public static bool CompareLes(int x, int y) => x > y;
        public static bool CompareLes(string x, string y) => y.CompareTo(x) == 1;
    }
}
