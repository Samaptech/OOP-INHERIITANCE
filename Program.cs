using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Person
    {
        protected string name;

        public Person(string name)
        {
            this.name = name;
        }
    }
    class teacher : Person
    {
        public teacher(string name) : base(name)
        {

        }
        public void explain()
        {
            Console.WriteLine("{0} is explaing", name);
        }

    }
    class student : Person
    {
        public student(string name) : base(name)
        {

        }
        public void study()
        {
            Console.WriteLine("{0} is studing", name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your name");
            teacher teacher1 = new teacher(Console.ReadLine());
            teacher1.explain();
            Console.WriteLine("write your name");
            student student1 = new student(Console.ReadLine());
            student1.study();

            Console.ReadKey();
        }
    }
}
