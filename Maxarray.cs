using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Maxarray
    {
        public void FindMax(int[,] a)
        {

            for (int i = 0; i < 3; i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }


                Console.WriteLine($"max element {max}");

            }
        }
        static void Main(string[] args)
        {
            int[,] ar = new int[3, 3];
            Console.WriteLine("Enter the element");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("array element");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ar[i, j]);
                }

            }
            Maxarray m = new Maxarray();
            m.FindMax(ar);
        }

    }
        
    
     class Sum
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int sum = 0;
            Console.WriteLine("enter the array element");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < a.Length; i++)
            {
               // int sum = 0;
                for(int j = i+1; j < a.Length; j++)
                {
                    sum = a[i] + a[j];
                    if (sum == 7)
                    {
                        Console.WriteLine($"{(a[i])},{(a[j])}");
                    }


                }
            }
        }
    }

    class Move
    {
        public void Movebegin(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {

                for (int j = i + 1; j < a.Length; j++)

                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        public void Movelast(int[] a)
        {
            for (int i = a.Length - 1; i > 0; i--)
            {
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
            }
        }
       static void Main(string[] args)
        {
            int[] ar = new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };

            Move m = new Move();
            m.Movebegin(ar);
            Console.WriteLine("move begin");
            foreach(var item in ar)
            {
                Console.WriteLine(item);
            }
            m.Movelast(ar);
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
    

