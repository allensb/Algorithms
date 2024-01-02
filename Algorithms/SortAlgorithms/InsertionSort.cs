namespace Algorithms
{
    static partial class SortAlgorithms
    {
        ///<summary>
        /// <para>Worst case = O(n^2)</para>
        /// <para>Average case = O(n^2)</para>
        ///</summary>
        public static string InsertionSort(int[] array)
        {
            for (var r = 1; r < array.Length; r++)
            {       
                var l = r;

                while (l > 0)
                {
                    if (array[l] <= array[l - 1])
                    {
                        var tmp = array[l - 1];
                        array[l - 1] = array[l];
                        array[l] = tmp;
                        l--;
                        continue;
                    }
                    break;
                }
            }

            return Util.ConvertToString(array);
        }
    }
}
