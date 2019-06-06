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
                new Student("Danut", "Vasilescu", "Sofia", 16, 2, 2006, "abcd@xyz.com", "45113"),
                new Student("Iordan", "Georgescu", "Sofia", 18, 1, 2006, "awdawdwa@abv.bg"),
                new Student("Mahnea", "Tezaur", "Iasi", 16, 2, 2003, "awdawdwa@abv.bg", "233154"),
                new Student("Magiun", "Ionescu", "Pocreaca", 26, 1, 2013, "zdxvz@342.bg"),
                new Student("Gigi", "Buzalau", "Sofia", 26, 1, 2001, "abcd@xysz.com", "45113"),
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

            Console.ReadKey();
        }

    }
}
