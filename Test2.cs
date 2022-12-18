using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Test2
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            int count = 0;
            char[] ch = s1.ToCharArray();
           // for(int i = 0; i < ch.Length; i++)
            
               // Console.WriteLine(ch[i]);
            
            Console.WriteLine();
            for (int i = 0; i < ch.Length; i++)
            {
                count = 0;
                for (int j = 0; j < ch.Length; j++)
                {
                    
                    if (ch[i] == ch[j] )
                    {
                        count++;
                       
                    }
                    
                }
               Console.WriteLine($"{ch[i]} {count}");

            }
             // Console.WriteLine($"{ch[i]} {count}");
        }
    }
    class Test3
    {
        public void Palindrome(string s1)
        {
            //copy=string s1;  
            char[] ch = s1.ToCharArray();
              Array.Reverse(ch);
            string srev = new string(ch);
            if (s1.Equals(srev))
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s1 = Console.ReadLine();
            Test3 t = new Test3();
            t.Palindrome(s1);
            
        }
    }
}
