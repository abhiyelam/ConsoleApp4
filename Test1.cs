using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Test1
    {
        static void Main(string[] args)
        {
            string s1 = "hell to all all";
            string[]  ar = s1.Split(" ");
            string s2 = "all";
            string s3 = "hello";
            int count = 0;
           
            Console.WriteLine(count);
            for (int i = 0; i < ar.Length; i++)
            {
                if (s2.Equals(ar[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count); ;
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s1[0]);
            Console.WriteLine(s1.IndexOf("h"));
            Console.WriteLine(s1.Replace("string","character"));
            Console.WriteLine(s1.LastIndexOf("i"));
            Console.WriteLine(s1.StartsWith("s"));
            char[] ch = s3.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine($" {i}  {ch[i]}");
            }
        }
    }
}
