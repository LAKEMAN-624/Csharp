using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace field
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stuList = new List<Student>();
            for(int i =0;i<100;i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;
                stuList.Add(stu);
            }
            int totalAge = 0;
            int totalScore = 0;
            foreach(var stu in stuList)
            {
                totalAge += stu.Age;
                totalScore += stu.Score;
            }
            Student.AverageAge = totalAge / Student.Amount;
            Student.AverageScore = totalScore / Student.Amount;

            Student.ReportAmount();
            Student.ReportAverageAge();
            Student.ReportAverageScore();
            Student stu1 = new Student(1);
            Console.WriteLine(stu1.ID);
            //stu1.ID = 2;
        }
    }
    class Student
    {
        public readonly int ID;
        public int Age;
        public int Score;

        public Student(int id)
        {
            this.ID = id;
        }

        public static int AverageAge;
        public static int AverageScore;
        public static int Amount;

        public Student()
        {
            Student.Amount++;
        }
        public static void ReportAmount()
        {
            Console.WriteLine(Student.Amount);
        }
        public static void ReportAverageAge()
        {
            Console.WriteLine(Student.AverageAge);
        }
        public static void ReportAverageScore()
        {
            Console.WriteLine(Student.AverageScore);
        }
    }
}
