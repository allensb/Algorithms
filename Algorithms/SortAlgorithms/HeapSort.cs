using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static partial class SortAlgorithms
    {
        ///<summary>
        /// <para>Worst case = O(n log(n))</para>
        /// <para>Average case = O(n log(n))</para>
        ///</summary>
        public static string HeapSort(int[] array)
        {
            var heapSize = array.Length;
            for (var i = (heapSize - 1) / 2; i > -1; i--)
                MaxHeapify(array, heapSize, i);

            for (var i = array.Length - 1; i > 0; i--)
            {
                var temp = array[i];
                array[i] = array[0];
                array[0] = temp;

                heapSize--;
                MaxHeapify(array, heapSize, 0);
            }

            return Util.ConvertToString(array);
        }

        private static void MaxHeapify(IList<int> array, int heapSize, int index)
        {
            var l = (index + 1)*2 - 1;
            var r = (index + 1)*2;
            int largest;

            if (l < heapSize && array[l] > array[index])
                largest = l;
            else
                largest = index;

            if (r < heapSize && array[r] > array[largest])
                largest = r;

            if (largest == index) return;

            var temp = array[index];
            array[index] = array[largest];
            array[largest] = temp;

            MaxHeapify(array, heapSize, largest);
        }
    }
}
