using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudentsLINQ.Classes
{
    class PrintingClass
    {
        public static void PrintNext()
        {
            Console.WriteLine("Press enter to print the next query");
            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key.Equals(ConsoleKey.Enter))
            {
                Console.Clear();
                return;
            }

            else
                PrintNext();
        }

        private static void PrintQuery<T>(IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
        public static void FirstBeforeLast(IEnumerable<Student> students)
        {
            Console.WriteLine("FIRST BEFORE LAST:");
            IEnumerable<Student> firstBeforeLast = Queries.FirstBeforeLast(students);
            PrintQuery(firstBeforeLast);
        }

        public static void AgeRange(IEnumerable<Student> students)
        {
            Console.WriteLine("AGE RANGE:");
            IEnumerable<Student> ageRange = Queries.AgeRange(students);
            PrintQuery(ageRange);
        }

        public static void OrderStudents(IEnumerable<Student> students)
        {
            Console.WriteLine("ORDER STUDENTS:");
            IEnumerable<Student> orderStudents = Queries.OrderStudents(students);
            PrintQuery(orderStudents);
        }

        public static void OrderStudentsLINQ(IEnumerable<Student> students)
        {
            Console.WriteLine("ORDER STUDENTS LINQ:");
            IEnumerable<Student> orderStudentsLinq = Queries.OrderStudentsLINQ(students);
            PrintQuery(orderStudentsLinq);
        }

        public static void StudentGroups(IEnumerable<Student> students)
        {
            Console.WriteLine("STUDENT GROUPS:");
            IEnumerable<Student> studentGroups = Queries.StudentGroup(students);
            PrintQuery(studentGroups);
        }

        public static void StudentGroupsLINQ(IEnumerable<Student> students)
        {
            Console.WriteLine("STUDENT GROUPS LINQ:");
            IEnumerable<Student> studentGroupsLinq = Queries.StudentGroupLINQ(students);
            PrintQuery(studentGroupsLinq);
        }

        public static void StudentsByPhone(IEnumerable<Student> students)
        {
            Console.WriteLine("STUDENTS BY PHONE:");
            IEnumerable<Student> studentsByPhone = Queries.StudentsByPhone(students);
            PrintQuery(studentsByPhone);
        }

        public static void StudentsByMarks(IEnumerable<Student> students)
        {
            Console.WriteLine("STUDENTS EXCELLET MARK:");
            var studentExcellentMarks = Queries.StudentsByMarks(students);
            foreach (var student in studentExcellentMarks)
            {
                Console.WriteLine($"Student: {student.FullName}");
                Console.Write("Marks: ");
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark);
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void StudentsWithTwoMarks(IEnumerable<Student> students)
        {
            Console.WriteLine("Students with only two marks: ");
            IEnumerable<Student> studentsWithTwoMarks = Queries.StudentsWithTwoMarks(students);
            PrintQuery(studentsWithTwoMarks);
        }

        public static void ExtractMarks(IEnumerable<Student> students)
        {
            Console.WriteLine("Marks of Students Enrolled in 2016: ");
            IEnumerable<float> marks2016 = Queries.ExtractMarks(students);
            PrintQuery(marks2016);
        }

        public static void Groups(IEnumerable<Student> students, List<Group> groups)
        {
            Console.WriteLine("Students in math: ");
            var studentsInMath = Queries.Groups(students, groups);
            foreach (var student in studentsInMath)
            {
                Console.WriteLine($"First Name: {student.FirstName}");
                Console.WriteLine($"Last Name: {student.LastName}");
                Console.WriteLine($"Department Name: {student.DepartmentName}");
                Console.WriteLine();
            }
        }

        public static void GroupedByGroupNumber(IEnumerable<Student> students)
        {
            Console.WriteLine("Students grouped by group number: ");
            var studentsByGroup = Queries.GroupedByGroupNumber(students);

            foreach (var student in studentsByGroup)
            {
                foreach (var s in student)
                {
                    Console.WriteLine($"First Name: {s.FirstName}");
                    Console.WriteLine($"Last Name: {s.LastName}");
                    Console.WriteLine($"Group Number: {s.GroupNumber}");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        public static void GroupedByGroupNumberLINQ(IEnumerable<Student> students)
        {
            Console.WriteLine("Students grouped by group number LINQ: ");
            var studentsByGroupLINQ = Queries.GroupedByGroupNumberLINQ(students);

            foreach (var student in studentsByGroupLINQ)
            {
                foreach (var s in student)
                {
                    Console.WriteLine($"First Name: {s.FirstName}");
                    Console.WriteLine($"Last Name: {s.LastName}");
                    Console.WriteLine($"Group Number: {s.GroupNumber}");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
