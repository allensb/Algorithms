using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Util
    {
        // Extending String object
        public static string ReverseString(this string s)
        {
            // funner way :)
            return string.Join(string.Empty, s.Reverse());

            //char[] charArray = s.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);
        }

        public static string ToUpperFirstLetter(this string source)
        {

            if (string.IsNullOrEmpty(source))
                return string.Empty;

            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);

            return new string(letters);

        }

        public static string ConvertToString(int[] array)
        {
            return String.Join(",", new List<int>(array).ConvertAll(i => i.ToString()).ToArray());
        }
    }
}
