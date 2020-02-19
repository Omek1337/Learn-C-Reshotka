using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 19} ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 16} ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 21} ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 18} ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 19} ,
                new Student() { StudentID = 6, StudentName = "Harry", Age = 10},
                new Student() { StudentID = 7, StudentName = "Barry", Age = 10},
                new Student() { StudentID = 8, StudentName = "RonGonzale", Age = 19} ,
                new Student() { StudentID = 9, StudentName = "Garry", Age = 10},
                new Student() { StudentID = 10, StudentName = "Karry", Age = 1}
            };

            IList<Standard> standardList = new List<Standard>()
            {
                new Standard() { StandardID = 1, StandardName = "A"},
                new Standard() { StandardID = 2, StandardName = "B"},
                new Standard() { StandardID = 3, StandardName = "C"},
                new Standard() { StandardID = 4, StandardName = "D"},
            };

            var selectResult = from s in studentList select s.StudentName;
            var selectRes = studentList.Select(s => new { Name = s.StudentName, Age = s.Age });
            var res = from s in studentList
                      where s.Age > 18
                      select s.StudentName;

            var lol = studentList.Where(x => x.Age > 18).Select(x => x.StudentName);

            var orderByAge = from x in studentList
                             orderby x.Age, x.StudentName
                             select x.StudentName;

            var groupedRes = from x in studentList
                             group x by x.Age;

            var innerJoin = from s in studentList
                            join st in standardList
                            on s.StudentID equals st.StandardID
                            select new { studentName = s.StudentName, standardName = st.StandardName };

            var innerJoinF = studentList.Join(standardList, studentItem => studentItem.StudentID,
                                                            standardItem => standardItem.StandardID, 
                                                            (studentItem, standardItem) => new { 
                                                                studentName = studentItem.StudentName, 
                                                                standardName = standardItem.StandardName});

            bool isAllAgeMoreThanEighty = studentList.All(x => x.Age < 80);
            bool isAnyAgeLessThanFive = studentList.Any(x => x.Age == 1);

            // Contains
            StudentComparer studentComparer = new StudentComparer();
            Student exampleStudent = new Student() { StudentID = 10, StudentName = "Karry", Age = 1 };
            var isExistsStudent = (from s in studentList
                                   select s).Contains(exampleStudent, studentComparer);

            var isExistsStudent1 = (from s in studentList
                                    select s.StudentID).Contains(exampleStudent.StudentID);


            // First, Single 
            var getFirstInList = studentList.First();
            var getForDInList = studentList.FirstOrDefault(s => s.Age > 19);
            var singleNameWith10Letters = studentList.Single(s => s.StudentName.Length == 10);
            var getSOrDNameWith10Letters = studentList.SingleOrDefault(s=> s.StudentName.Length == 10);
            foreach (var item in innerJoinF)
            {
                Console.WriteLine(item.standardName + "  " + item.studentName);
            }

            Console.ReadLine();
        }
    }
}
