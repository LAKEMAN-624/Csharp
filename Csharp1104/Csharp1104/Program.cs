using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1104
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu1= new Student() { ID = 1, Name = "fun" };
            Student stu1 = new Student(1, "fun");
            Student stu2 = new Student(2, "kcn");

            //Student stu = new Student(1,"fun") ;
            //Console.WriteLine(stu.ID);
            //Console.WriteLine(stu.Name);
            //stu.Report();
            Console.WriteLine(Student.Amount);
        }

    }
    class Student
    {
        public static int  Amount { get; set; }
        static Student()
        {
            Amount = 100;
        }
       // 实例构造器
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            Amount++;
        }
        //析构器
        ~Student()
        {
            Console.WriteLine("bye. release the system resources..");
            Amount--;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I'm #{this.ID}student, my name is {this.Name}.");
        }
    }
}
