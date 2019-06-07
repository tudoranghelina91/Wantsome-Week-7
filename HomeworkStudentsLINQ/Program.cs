using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkStudentsLINQ.Classes;

namespace HomeworkStudentsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>()
            {
                new Group("Mathematics"),
                new Group("Physics"),
                new Group("Arts")
            };

            IEnumerable<Student> students = new List<Student>()
            {
                new Student("Danut", "Vasilescu", "Sofia", 16, 2, 2006, "abcd@xyz.com", new List<float>() {2.3f, 6f }, "45113"),
                new Student("Iordan", "Georgescu", "Sofia", 18, 1, 2006, "awdawdwa@abv.bg", new List<float>() {6f, 2.6f, 3.2f }),
                new Student("Mahnea", "Tezaur", "Iasi", 16, 2, 2003, "awdawdwa@abv.bg", new List<float>() {6f, 4f }, "233154"),
                new Student("Magiun", "Ionescu", "Pocreaca", 26, 1, 2013, "zdxvz@342.bg", new List<float>() {5.3f, 1.6f, 2f }),
                new Student("Gigi", "Buzalau", "Sofia", 26, 1, 2001, "abcd@xysz.com",new List<float>() {3.3f, 2.6f, 1f }, "45113"),
            };

            Console.WriteLine("FIRST BEFORE LAST:");
            IEnumerable<Student> firstBeforeLast = Queries.FirstBeforeLast(students);
            foreach (Student student in firstBeforeLast)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("AGE RANGE:");
            IEnumerable<Student> ageRange = Queries.AgeRange(students);
            foreach (Student student in ageRange)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("ORDER STUDENTS:");
            IEnumerable<Student> orderStudents = Queries.OrderStudents(students);
            foreach (Student student in orderStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("ORDER STUDENTS LINQ:");
            IEnumerable<Student> orderStudentsLinq = Queries.OrderStudentsLINQ(students);
            foreach (Student student in orderStudentsLinq)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("STUDENT GROUPS:");
            IEnumerable<Student> studentGroups = Queries.StudentGroup(students);
            foreach (Student student in studentGroups)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("STUDENT GROUPS LINQ:");
            IEnumerable<Student> studentGroupsLinq = Queries.StudentGroupLINQ(students);
            foreach (Student student in studentGroupsLinq)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("STUDENTS BY PHONE:");
            IEnumerable<Student> studentsByPhone = Queries.StudentsByPhone(students);
            foreach (Student student in studentsByPhone)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("STUDENTS EXCELLET MARK:");
            IEnumerable<object> studentExcellentMarks = Queries.StudentsByMarks(students);
            foreach (object student in studentExcellentMarks)
            {
                // nu stiu cum sa formatez rezultatul
                StringBuilder studentExcellent = new StringBuilder();
                Console.WriteLine(student);
            }


            Console.WriteLine("Students with only two marks: ");
            IEnumerable<Student> studentsWithTwoMarks = Queries.StudentsWithTwoMarks(students);
            foreach (Student student in studentsWithTwoMarks)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Students in math: ");
            IEnumerable<Student> studentsInMath = Queries.StudentGroup(students);
            foreach (Student student in studentsInMath)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Marks of Students Enrolled in 2016: ");
            IEnumerable<float> studentsEnrolled2016 = Queries.ExtractMarks(students);
            foreach (float mark in studentsEnrolled2016)
            {
                Console.WriteLine(mark);
            }

            //Console.WriteLine("Students grouped by group number: ");
            //IEnumerable<Student> studentsByGroup = Queries.GroupedByGroupNumber(students);
            //foreach (Student student in studentsByGroup)
            //{
            //    Console.WriteLine(student);
            //}

            Console.ReadKey();
        }

    }
}
