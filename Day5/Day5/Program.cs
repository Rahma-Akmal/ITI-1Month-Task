
namespace Day5
{

    internal class Program
    {
        interface MyInterface<T>
        {
            T GetByIndex(int index);
        }

    public class Stack<T>:MyInterface<T>
        {
            int size;
            int top;
            T[] arr;
            public T this[int index]
            {
                get { return arr[index]; }
            }
            public static Stack<T> operator+(Stack<T> s1, Stack<T> s2)
            {
                int newSize = s1.size + s2.size;
                Stack<T> s3 = new Stack<T>(newSize);

                for (int i = 0; i < s1.top; i++)
                {
                    s3.push(s1.arr[i]);
                }

                for (int i = 0; i < s2.top; i++)
                {
                    s3.push(s2.arr[i]);
                }

                return s3;
            }
            public static explicit operator Stack<T>(T[] arr)
            {
                Stack<T> s=new Stack<T>(arr.Length);

                foreach(T i in arr)
                {
                    s.push(i);
                }
                return s;
            }
            public int Size
            {
                get { return size; }
            }
            public void push(T x)
            {
                if (top <= size - 1)
                {
                    arr[top] = x;
                    top++;
                }
                else
                {
                    Console.WriteLine("Stack FUll");
                }
            }
            public T pop()
            {
                T returnval = default(T);
                if (top > 0)
                {
                    top--;
                    returnval = arr[top];
                }
                else
                {
                    Console.WriteLine("Stack Empty");
                }
                return returnval;
            }
            public T peek()
            {
                T returnval = default(T);
                if (top > 0)
                {
                    returnval = arr[top];
                }
                else
                {
                    Console.WriteLine("Stack Empty");
                }
                return returnval;
            }

            public T GetByIndex(int index)
            {
               if(index>=0 && index < top)
               {
                    return arr[index];
               }
                else
                {
                    return default(T);  

                }
            }

            public Stack()
            {
                top = 0;
                size = 5;
                arr = new T[size];
            }
            public Stack(int size)
            {
                this.size = size;
                top= 0;
                arr = new T[size];
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.push(1); 
            stack.push(2);
            //stack.push(3);
            //stack.push(4);
            //stack.push(5);
            Stack< int> s2 = new Stack<int>();
            s2.push(1);
            s2.push(2);
            s2.push(3);
            Stack<int> s3=stack+s2;
            for (int i = 0; i < s3.Size; i++)
            {
                if (i < s3.Size && s3[i] != 0) 
                    Console.WriteLine(s3[i]);
            }
            Console.WriteLine("-------------");
            int[] arr = { 1, 2, 3 };
            Stack<int> s = (Stack<int>)arr;
            for(int i = 0;i < s.Size; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine("-------------");

            int[] ar = { 1, 2, 3 };
            Stack<int> stack1 = (Stack<int>)ar;
            for (int i = 0; i < s.Size; i++)
            {
                Console.WriteLine(s[i]);
            }
            stack1.GetByIndex(0);
            stack1.GetByIndex(1);
            stack1.GetByIndex(2);
            stack1.GetByIndex(3);
            //Console.WriteLine("----------");
            //Console.WriteLine(stack.pop());
        }
    }
}
