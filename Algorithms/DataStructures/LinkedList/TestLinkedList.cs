namespace Algorithms.DataStructures
{
    static class TestLinkedList
    {
        public static void Run()
        {
            var list = new LinkedList<int>();

            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddLast(8);

            ListNodes<int>(list);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Deleting node 8");
            list.RemoveLast();
            ListNodes<int>(list);

            Console.WriteLine();
            Console.WriteLine("Position 4: " + list.Retrieve(4).Value);

            Console.WriteLine();
            Console.WriteLine("Deleting node 3");
            list.Remove(3);

            Console.WriteLine();
            Console.WriteLine("Position 4: " + list.Retrieve(4).Value);

            Console.WriteLine();
            ListNodes<int>(list);

            Console.ReadLine();
        }

        private static void ListNodes<T>(IEnumerable<T> list)
        {
            var enumerated = list.GetEnumerator();
            while (enumerated.MoveNext()) {
                Console.WriteLine(enumerated.Current);
            }
        }
    }
}
