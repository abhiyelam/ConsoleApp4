using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }
    class Productlist
    {
        static void Main(string[] args)
        {
           // Product p = new Product { Id = 1, Name = "battery", Price = 500 };
            //Product p1 = new Product{ Id = 2, Name = "bat", Price = 400 };
           // Console.WriteLine(p);
            //Console.WriteLine(p1);

            List<Product> list = new List<Product>();

            list.Add(new Product { Id = 1, Name = "mobile", Price = 10000 });
            list.Add(new Product { Id = 2, Name = "watch", Price = 3000 });
            list.Add(new Product { Id = 3, Name = "headphone", Price = 1000 });
            list.Add(new Product { Id = 4, Name = "cycle", Price = 4000 });
            foreach(var p in list)
            {
                Console.WriteLine($"{p.Id}  {p.Name}  {p.Price}");
            }

            foreach (var p in list)
            {
                if(p.Price<2000)
                Console.WriteLine($"{p.Name} {p.Price}");
            }

        }
    }
}
