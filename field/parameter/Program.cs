using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name="Tim"};
            UpdateObject(stu);
            Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);
        }
        static void UpdateObject(Student stu)
        {
            stu = new Student() { Name = "Tom" };
            //stu.Name ="Tom";//副作用
            Console.WriteLine("HashCode={0}, Name={1}", stu.GetHashCode(), stu.Name);
        }
    }
    class Student
    {
        public string Name { get; set; }
    }
}
