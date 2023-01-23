namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            listDemo();
            stackDemo();
            dictionaryDemo();
            setDemo();
            queueDemo();
        }
        public static void queueDemo()
        {
            Console.WriteLine("Queue Demo");
            Queue<char> queue = new Queue<char>();
            queue.Enqueue('a');
            queue.Enqueue('a');
            queue.Enqueue('b');
            queue.Enqueue('c');
            queue.Enqueue('d');
            Console.WriteLine($"top of queue : {queue.Peek()}");
            foreach(var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"dequeue element : {queue.Dequeue()} ");
            Queue<char>.Enumerator iterator= queue.GetEnumerator();
            //enumerator can be used for iterating through the queue
            while(iterator.MoveNext() )
            {
                Console.WriteLine(iterator.Current);
            }
            Console.WriteLine("-----------------------------------------------");
        }
        public static void listDemo()
        {
            Console.WriteLine("List Demo");
            List<int> list = new List<int>();
            int[] arr = { 1, 2, 3 };
            list.AddRange(arr);
            list.Add(10);
            list.Remove(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------");
        }
        public static void stackDemo()
        {
            Console.WriteLine("Stack Demo");
            Stack<char> stack = new Stack<char>();
            stack.Push('a');
            stack.Pop();
            stack.Push('b');
            stack.Push('c');
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("-----------------------------------------------");
        }
        public static void dictionaryDemo()
        {
            Console.WriteLine("Dictionary Demo");
            Dictionary<int,string> map = new Dictionary<int,string>();
            map.Add(1,"arpit");
            map.Add(2, "harsh");
            map.Add(3, "kamal");
            int x = 3;
            Console.WriteLine($"string mapped to integer {x} is {map[x]}");
            map.Remove(x);
            foreach(var pair in map)
            {
                Console.WriteLine($"the pair is {pair.Value}-->{pair.Key}");
            }
            Console.WriteLine("-----------------------------------------------");
        }
        public static void setDemo()
        {
            Console.WriteLine("Set Demo");
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(2);
            foreach(var i in set)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------------------");
        }
    }
}