using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class StudentClass
    {
        /// <summary>
        /// 班级内学生储存在Student类型的数组中，本例一个班最多只能有35位学生
        /// </summary>
        private Student[] students = new Student[35];

        /// <summary>
        /// 索引器，通过索引器可以方便地访问数组中的数学对象
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Student this[int i]
        {
            get
            {

                if ((i >= 0) && (i < students.Length))
                {
                    return students[i];
                }
                else//否则返回null
                {
                    return null;
                }
            }
            //set访问器
            set
            {
                if ((i >= 0) && (i < students.Length))
                {
                    students[i] = value;
                }
            }
        }
    }
}
