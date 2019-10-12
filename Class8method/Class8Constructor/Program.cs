using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine(stu.ID);
        }
    }

    class Student
    {
        public Student()
        {
            this.ID = 1;
            this.Name = "No Name";
        }
        public int ID;
        public string Name;
    }
}
