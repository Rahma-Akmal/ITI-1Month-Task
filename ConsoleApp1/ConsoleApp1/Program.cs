using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class program
    {
        //static void modifystring (string str)
        //{
        //    str = "modified string";

        //}
        //static void modifystringref (ref string str)
        //{
        //    str = "modified string";

        //}


        static void Main(string[] args)
        {

            #region MyRegion
            //int N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    //for (int j = 1; j < N - 1; j++)
            //    //{
            //    //    Console.WriteLine();
            //    //}

            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("\n*");

            //    }
            //    }


            //int NUM = Convert.ToInt32(Console.ReadLine());
            //int res = 1;
            //for (int i = 1; i < NUM + 1; i++)
            //{
            //    res *=i;
            //}
            //Console.WriteLine(res);

            //int A= Convert.ToInt32(Console.ReadLine());
            //int B= Convert.ToInt32(Console.ReadLine());
            //for (int i = A;i<= B;i++)
            //{
            //    int d= i;
            //    while (d > 0)
            //    {   int n=d%10;
            //        d /= 10;
            //        if (n == 4 || n == 7)
            //        {
            //            Console.WriteLine(d);


            //        }

            //    }
            //}

            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //char s=Convert.ToChar(Console.ReadLine());
            //if (s == '+')
            //{
            //    Console.WriteLine(A + B);
            //}
            //else if(s == '*')
            //{
            //    Console.WriteLine(A*B);
            //}
            //else if (s == '-')
            //{
            //    Console.WriteLine(A-B);
            //}
            //else
            //{
            //    Console.WriteLine(A/B);
            //} 
            #endregion

            //string original = "original string";
            //Console.WriteLine(original);
            //modifystring(original);
            //Console.WriteLine(original);

            //modifystringref( ref original);
            //Console.WriteLine(original);
            //int firstValue = 500;
            //int secondValue = 600;
            //int largerValue=Math.Max(firstValue,secondValue);

            //Console.WriteLine(largerValue);

            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            //// string result = new string(valueArray);
            //string result = String.Join( valueArray);
            //Console.WriteLine(result);


            int x = 10;
            int y = 3;
            int result = x % y;
            Console.WriteLine(result);
        }

    }




}

