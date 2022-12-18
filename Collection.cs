using System;
using System.Collections;
using System.Text;

namespace ConsoleApp4
{
    class Collection
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Pop();
            Console.WriteLine("top element on stack"+st.Peek());
            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine( );
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
           
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine("after the queue delete element");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 10);
            hashtable.Add(2, 20);
            hashtable.Add(3, 30);
                hashtable.Add(4, 40);
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key} { item.Value}");
                    
            }

        }
    }
}
