using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudentsLINQ.Classes
{
    class Queries
    {
        public static IEnumerable<Student> FirstBeforeLast(IEnumerable<Student> students)
        {
            IEnumerable<Student> firstBeforeLast = from student in students
                              where (student.FirstName.CompareTo(student.LastName) <= 0)
                              select student;

            return firstBeforeLast;              
        }

        public static IEnumerable<Student> AgeRange(IEnumerable<Student> students)
        {
            IEnumerable<Student> ageRange = from student in students
                              where (student.Age >= 18 && student.Age <= 24)
                              select student;

            return ageRange;                 
        }

        public static IEnumerable<Student> OrderStudents(IEnumerable<Student> students)
        {
            IEnumerable<Student> orderStudents;

            orderStudents = students.OrderByDescending(student => student.FirstName)
                                    .ThenByDescending(student => student.LastName);

            return orderStudents;
        }

        public static IEnumerable<Student> OrderStudentsLINQ(IEnumerable<Student> students)
        {
            IEnumerable<Student> orderStudents = from student in students
                            orderby student.FirstName descending
                            orderby student.LastName descending
                            select student;

            return orderStudents;
        }

        public static IEnumerable<Student> StudentGroup(IEnumerable<Student> students)
        {
            IEnumerable<Student> studentGroups = students.Where(student => student.GroupNumber == 2)
                                    .OrderBy(student => student.FirstName);

            return studentGroups;
        }

        public static IEnumerable<Student> StudentGroupLINQ(IEnumerable<Student> students)
        {
            IEnumerable<Student> studentGroups = from student in students
                            where student.GroupNumber == 2
                            orderby student.FirstName
                            select student;

            return studentGroups;
        }

        public static IEnumerable<Student> StudentsByEmail(IEnumerable<Student> students)
        {
            IEnumerable<Student> studentsByEmail = from student in students
                              where student.Email.EndsWith("abv.bg")
                              select student;

            return studentsByEmail;
        }

        public static IEnumerable<Student> StudentsByPhone(IEnumerable<Student> students)
        {
            IEnumerable<Student> studentsByPhone = from student in students
                              where student.Tel != "" && student.City == "Sofia"
                              select student;

            return studentsByPhone;
        }

        public static IEnumerable<object> StudentsByMarks(IEnumerable<Student> students)
        {
            var studentMarks = from student in students
                               where student.Marks.Contains(6)
                               select new
                               {
                                   FullName = student.FirstName + " " + student.LastName,
                                   Marks = string.Join(", ", student.Marks)
                               };

            return studentMarks;
        }

        public static IEnumerable<Student> StudentsWithTwoMarks(IEnumerable<Student> students)
        {
            IEnumerable<Student> studentsWithTwoMarks = students.Where(student => student.Marks.Count == 2);
            return studentsWithTwoMarks;
        }

        public static List<float> ExtractMarks(IEnumerable<Student> students)
        {
            IEnumerable<Student> studentsEnrolledInYear = students.Where(student => student.FN / 1000 % 10 == 6 && student.FN / 10000 % 10 == 0);
            List<float> marks = new List<float>();
            foreach (Student student in studentsEnrolledInYear)
                foreach (float mark in student.Marks)
                    marks.Add(mark);

            return marks;
        }

        public static IEnumerable<Student> Groups(IEnumerable<Student> students, List<Group> groups)
        {
            IEnumerable<Student> studentsInMath = from student in students
                                                  join g in groups
                                                  on student.GroupNumber equals g.GroupNumber
                                                  where g.DepartmentName == "Mathematics"
                                                  select student;

            return studentsInMath;
        }

        // TODO THIS
        public static IEnumerable<Student> GroupedByGroupNumberLINQ(IEnumerable<Student> students)
        {
            var studentsGroupedByGroupNumber = from student in students
                                               group student by student.GroupNumber into g
                                               select g;


            return studentsGroupedByGroupNumber as IEnumerable<Student>;
        }

        // TODO THIS
        public static IEnumerable<Student> GroupedByGroupNumber(IEnumerable<Student> students)
        {
            var studentsGroupedByGroupNumber = students.GroupBy(student => student.GroupNumber);

            return studentsGroupedByGroupNumber as IEnumerable<Student>;
        }
    }
}
