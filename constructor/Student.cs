using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.constructor
{
    class Student
    {
        public int id;
        public string name;
        public int percent;

        public Student(int id, string name, int percent)
        {
            this.id = id;
            this.name = name;
            this.percent = percent;
        }
        public override string ToString()
        {
            return $"id {id} name{name} percent {percent}";
        }
    }

    class Test8
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "abhi", 75);
            Student s1 = new Student(2, "manish", 65);
            Console.WriteLine(s);
            Console.WriteLine(s1);
        }
    }

}
