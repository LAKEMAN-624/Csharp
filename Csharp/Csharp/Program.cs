using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明Student类型的对象
            Student firstStudent;
            firstStudent = new Student();
            firstStudent.Name = "关羽";
            firstStudent.Birthday = new DateTime(1990, 1, 2);
            firstStudent.StudentID = "0962101";
           
            //声明Student类型的对象
            Student firstStudent;
            firstStudent = new Student();
            firstStudent.Name = "张飞";
            firstStudent.Birthday = new DateTime(1992, 3, 15);
            firstStudent.StudentID = "0962102";

            //声明并创建学生班级对象
            StudentClass firstStudentClass = new StudentClass();
            //通过索引器，把firstStuent对象存储到firstStudentClass的students数组中
            //其序号为0
        }
    }
}
