using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Ademo
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5] { 2, 3, 4, 5, 6 };
            Array.Sort(ar);
            Array.Reverse(ar);
            int result = ar[0] * ar[1];
            Console.WriteLine(result);

        }
    }
    class Arraydemo
    {
        static void Main(string[] args)
        {
            //int no = int.Parse(Console.ReadLine());
            int[] ar = new int[5] { 3,4,5,6,7};
            Array.Sort(ar);
            int a = ar[1];
            Array.Reverse(ar);
            int b = ar[1];
            int result = a * b;
            Console.WriteLine(result);
        }
        
    }
}
