using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (object.ReferenceEquals(x, y)) { return true; }
            if (x is null || y is null)
            {
                return false;
            }
            return x.StudentID == y.StudentID && x.StudentName == y.StudentName && x.Age == y.Age;
        }

        public int GetHashCode(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
