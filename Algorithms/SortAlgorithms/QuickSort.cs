using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static partial class SortAlgorithms
    {
        ///<summary>
        /// <para>Worst case = O(n^2)</para>
        /// <para>Average case = O(n log(n))</para>
        ///</summary>
        public static string QuickSort(int[] array)
        {
            QuickSortR(array, 0, array.Length - 1);
            return Util.ConvertToString(array);

        }

        public static void QuickSortR(int[] array, int left, int right)
        {
            int l = left, r = right;
            int pivot = array[(l + r) / 2];

            while (l <= r)
            {
                while (array[l] < pivot)
                {
                    l++;
                }
                while (array[r] > pivot)
                {
                    r--;
                }

                if (l > r) continue;

                var tmp = array[l];
                array[l] = array[r];
                array[r] = tmp;

                l++;
                r--;
            }

            if (left < r)
                QuickSortR(array, left, r);
            if (l < right)
                QuickSortR(array, l, right);
        }
    }
}
