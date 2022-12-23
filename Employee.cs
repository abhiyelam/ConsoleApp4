using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

       public Employee(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        
        
        public override string ToString()
        {
            return $"{id} {name} {salary}";
        }
        
    }
    class Program3
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "Abhi", 35000);
            Employee e1 = new Employee(2, "manish", 30000);
            Employee e2 = new Employee ( 3,"aarav",25000 );

            Console.WriteLine(e);
            Console.WriteLine(e1);
            Console.WriteLine(e2);

            Console.WriteLine();
            Employee[] ar = new Employee[]
            {
                new Employee(1,"abhi",40000),
                 new Employee(2,"manish",50000),
                  new Employee(3,"abhi",60000),
            };

            foreach(var emp in ar)
            {
                Console.WriteLine(emp);
            }

        }
    }

}   