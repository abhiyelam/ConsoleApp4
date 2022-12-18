using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Program2
    {
        int l = 0;
        static void Main(string[] args)
        {
            int no = int.Parse(Console.ReadLine());
            int l = 0;
            while (no > 0)
            {
               // int l = 0;
                int rem = no % 10;
                if (rem > l)
                {
                    l = rem;
                }

                no = no / 10; 
            }
            Console.WriteLine(l);

        }
    }
}
