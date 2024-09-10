namespace BubbleSort
{
    internal class Program
    {
        public delegate bool bubble<T>(T x, T y);
        public static void swap<T>(List<T> list, int ix, int ix2)
        {
            T temp = list[ix];
            list[ix] = list[ix2];
            list[ix2] = temp;
        }
        public static void bubbleS<T>(List<T> l, bubble<T> bubble)
        {
            for (int i = 0; i < l.Count - 1; i++)
            {
                for (int j = 0; j < l.Count - 1 - i; j++)
                {
                    if (bubble(l[j], l[j + 1]))
                     {
                        swap(l, j, j+1);
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> l = [1,2,3,4,5];
            bubbleS(l, (x, y) => x > y);
            Console.WriteLine("Asc sort");
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);

            }
            bubbleS(l, (x, y) => x < y);
            Console.WriteLine("desc sort");
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);

            }

        }
    }
}
