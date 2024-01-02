namespace Algorithms
{
    static partial class SortAlgorithms
    {
        ///<summary>
        /// <para>Worst case = O(n log(n))</para>
        /// <para>Average case = O(n log(n))</para>
        /// <para>Is in-place (takes extra memory compared to Quick Sort)</para>
        ///</summary>
        public static string MergeSort(int[] array)
        {
            MergeSortR(array, 0, array.Length - 1);

            return Util.ConvertToString(array);
        }

        public static void MergeSortR(int[] array, int left, int right)
        {
            if (right > left)
            {
                int pivot = (right + left)/2;
                MergeSortR(array, left, pivot);
                MergeSortR(array, (pivot + 1), right);

                MergeRecursive(array, left, (pivot + 1), right);
            }
        }

        private static void MergeRecursive(IList<int> array, int left, int pivot, int right)
        {
            var temp = new int[array.Count];

            int eol = (pivot - 1);
            int pos = left;
            int num = (right - left + 1);

            while ((left <= eol) && (pivot <= right))
            {
                if (array[left] <= array[pivot])
                {
                    temp[pos++] = array[left++];
                }
                else
                {
                    temp[pos++] = array[pivot++];
                }
            }

            while (left <= eol)
                temp[pos++] = array[left++];

            while (pivot <= right)
                temp[pos++] = array[pivot++];

            for (var i = 0; i < num; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
    }
}
