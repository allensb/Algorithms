namespace Algorithms
{
    static partial class SortAlgorithms
    {
        ///<summary>
        /// <para>Worst case = O(n^2)</para>
        /// <para>Average case = O(n^2)</para>
        ///</summary>
        public static string SelectionSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                var tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }

            return Util.ConvertToString(array);
        }
    }
}
