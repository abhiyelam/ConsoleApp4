using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine("Enter the no");
           // int no = int.Parse(Console.ReadLine());
            for(int i = 1; i <=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if(i % 3 == 0)
                    {
                     Console.WriteLine("no is divisible by 3 fizz");
                }
                
            }
            
             
            
        }
    }
}
