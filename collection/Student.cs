using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.collection
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public List<Student> studlist = new List<Student>();
    }
    public class Test6
    {
        static void Main(string[] args)
        {
            List<Course> list = new List<Course>()
            {
                new Course{
                    Id=1,
                    Name="C#",
                    Fees=20000,
                    studlist={new Student { Id=1,Name="Abhi",City="pune"},
                                new Student{Id=2,Name="manish",City="hyderabad"}
                               }
                },
                new Course{
                    Id=2,
                    Name="mvc",
                Fees = 25000,
                studlist ={
                new Student { Id = 1, Name = "Abhi", City = "pune" },
                                new Student { Id = 2, Name = "manish", City = "hyderabad" }
                    }
                }
                
             };


            foreach (Course c in list)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
                foreach (Student s in c.studlist)
                {
                    Console.WriteLine($"{s.Id} {s.Name} /t{s.City}");
                }

            }
        }
    }
}
