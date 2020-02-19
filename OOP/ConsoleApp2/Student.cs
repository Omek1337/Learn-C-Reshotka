using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    
    class Student
    {

        public int StudentID;
        public string StudentName;
        public int Age;

        public Student(int studentID, string studentName, int age)
        {
            StudentID = studentID;
            StudentName = studentName;
            Age = age;
        }
        public Student() { }
    }
}
