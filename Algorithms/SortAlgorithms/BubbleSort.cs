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
        /// <para>Average case = O(n^2)</para>
        ///</summary>
        public static string BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }

            return Util.ConvertToString(array);
        }
    }
}
