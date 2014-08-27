using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        private static readonly int[] Array = { 7, 3, 1, 67, 723, 12, 55, 789, 33, 21, 902, 11 };

        static void Main(string[] args)
        {
            Console.WriteLine("Function:");

            var function = Console.ReadLine();
            if (function != null)
            {
                if (function.ToLower().Contains("sort"))
                    Console.WriteLine(InvokeSortAlgorithm(function.ToUpperFirstLetter()));
                else if (function.ToLower().Contains("linkedlist"))
                {
                    Algorithms.DataStructures.TestLinkedList.Run();
                }
                else
                {
                    Console.WriteLine("Number:");
                    int num;
                    int.TryParse(Console.ReadLine(), out num);

                    if (function.ToLower() == "largestproductinseries")
                        Console.WriteLine(InvokeAlgorithm<long>(function, num));
                    else if (function.ToLower() == "sumofcoins")
                    {
                        var result = InvokeAlgorithm<List<string>>(function, num);
                        Console.WriteLine(string.Join("\n", result));
                        Console.WriteLine(" ");
                        Console.WriteLine("Result Count: " + result.Count);
                    }
                    else
                        Console.WriteLine(InvokeAlgorithm<int>(function, num));
                }
            }

            Console.ReadLine();
        }

        static string InvokeSortAlgorithm(string methodName)
        {
            MethodInfo method = typeof(SortAlgorithms).GetMethod(methodName, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public);
            return (string)method.Invoke(null, new object[] { Array });
        }

        static T InvokeAlgorithm<T>(string methodName, int num = 0)
        {
            MethodInfo method = typeof(MiscAlgorithms).GetMethod(methodName, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public);
            return (T)method.Invoke(null, (num == 0 ? new object[] { } : new object[] { num }));
        }
    }
}
