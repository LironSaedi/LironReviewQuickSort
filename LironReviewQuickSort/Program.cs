
using System;
using System.Collections.Generic;

namespace LironReviewQuickSort
{
    class Program
    {

        public static void QuickSort<T>(T[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        static void QuickSort<T>(T[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex) return;

            int pivot = LumotoLogic(array, startIndex, endIndex);

            //Pivot is fully sorted
            QuickSort(array, startIndex, pivot - 1);
            QuickSort(array, pivot + 1, endIndex);
        }

        static int LumotoLogic<T>(T[] array, int startIndex, int endIndex)
        {
            int pivot = endIndex;
            int wall = startIndex - 1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                //Soritnbg Alrgorithm HEere
            }


            return pivot;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
