using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Stringdemo
    {
        static void Main(string[] args)
        {
            string s1 = "dog";
            string s2 = "god";
            char[] ch = s1.ToCharArray();
            char[] ch1 = s2.ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch1);
            string s3 = new string(ch);
            string s4 = new string(ch1);
            if (s3.Equals(s4))
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("string is not anagram");
            }
        }
    }

    class Test5
    {
        public void Fib(int no)
        {
            int a, b = 1, c = 0;
            for (int i = 1; i <= no; i++)
            {
                Console.Write(c);
                a = b;
                b = c;
                c = a + b;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int no = int.Parse(Console.ReadLine());
            Test5 t = new Test5();
            t.Fib(no);
        }
    }
}
    
    
        
  



      
             
    

