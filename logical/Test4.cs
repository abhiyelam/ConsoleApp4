using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Test4
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            //stack.Count();
            Console.WriteLine($" top element of stack {stack.Peek()}");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Queue<string> q = new Queue<string>();
            q.Enqueue("Abhi");
            q.Enqueue("manish");
            q.Enqueue("Aarav");
            q.Enqueue("Gopal");
            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("List");
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            list.Reverse();
            Console.WriteLine("after the reverse list");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            
            list.Remove(30);
            Console.WriteLine("list after the remove element");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(count);
            /*List<Emp> listemp = new List<Emp>()
             {
             new Emp{Id=1,Name="Abhi",Salary=35000},
              new Emp{Id=2,Name="manish",Salary=25000},
               new Emp{Id=3,Name="gopal",Salary=30000},
             };
             foreach(emp e in listemp)
            {
                 Console.WriteLine($"{e.Name}{e.id}");
              }*/
        }
    }
}
