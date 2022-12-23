using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.demod
{
    
    
    public delegate int Mydeli1(int n1, int n2);
    public delegate string Mydeli2(string s);
    
    public class Test
    {
        public int M1(int a,int b)
        {
        return a + b;
        }
        
        public string M2(string name)
        {
             return name.ToUpper();
        }
    }

    public class Test10
    {
        static void Main(string[] args)
        {
            Test t = new Test();
        Mydeli1 d1 = new Mydeli1(t.M1);
       
                int sum=d1.Invoke(5, 4);
        Console.WriteLine(sum);
            Mydeli2 d2 = new Mydeli2(t.M2);
            string str = d2.Invoke("think");
            Console.WriteLine(str);
        }
    }
}
