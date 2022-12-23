using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.collection
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  int Price { get; set; }
        


    }
    class Author
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> blist = new List<Book>();
    }
    class Test7
    {
        static void Main(string[] args)
        {
            List<Author> list = new List<Author>()
            {
                new Author
                {
                    Id=1,
                    Name="jmesgosling",
                    blist={new Book{Id=1,Name="java",Price=400},
                            new Book{Id=2,Name="c#",Price=300}
                    }
                },
                new Author
                {
                    Id=2,
                    Name="Mahatma Gandhi",
                    blist={new Book { Id=1,Name="Life of M Gandhi",Price=450},
                            new Book{Id=2,Name="india of my dreams",Price=500}
                    }
                },
            };
            foreach(Author a in list)
            {
                Console.WriteLine($"{a.Id} {a.Name}");
                foreach(Book b in a.blist)
                {
                    Console.WriteLine($"/t{b.Id} \t{b.Name} {b.Price}");
                }
            }
        }
    }
}
