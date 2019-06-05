using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkLINQ.Classes;
using System.Collections;

namespace HomeworkLINQ
{
    class StudentExtension
    {
        public static Student[] where(Student[] stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (Student std in stdArray)
                if (del(std))
                    result[i++] = std;

            return result;
        }
    }
    delegate bool FindStudent(Student std);
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLE: WHAT IS LINQ - LINQ Query to Array
            // data source
            string[] names = { "Gigi", "Gogu", "Vasile", "Ion" };

            // LINQ Query
            IEnumerable<string> myLinqQuery = from name in names
                              where name.Contains('i')
                              select name;

            // Query execution
            foreach (string name in myLinqQuery)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();
            Console.WriteLine("=====================================");

            // WHY LINQ - EXAMPLE: FOR LOOP TO FIND ELEMENTS FOR COLLECTION C# 1.0

            Student[] studentArray = {
                new Student("John", 18),
                new Student("Steve", 21),
                new Student("Bill", 25),
                new Student("Ram", 20),
                new Student("Ron", 31),
                new Student("Chris", 17),
                new Student("Rob", 19)
            };

            Student[] students = new Student[10];

            int i = 0;
            foreach (Student std in studentArray)
            {
                if (std.Age > 12 && std.Age < 20)
                    students[i++] = std;
            }

            foreach (Student std in students)
            {
                Console.WriteLine(std);
            }

            Console.WriteLine("======================================");

            // WHY LINQ - EXAMPLE: USE DELEGATES TO FIND ELEMENTS FROM THE COLLECTION IN C# 2.0

            students = StudentExtension.where(studentArray, delegate (Student std)
            {
                return std.Age > 12 && std.Age < 20;
            });

            foreach (Student std in students)
            {
                Console.WriteLine(std);
            }

            Console.WriteLine("========================================");

            students = StudentExtension.where(studentArray, delegate (Student std)
            {
                return std.StudentID == 5;
            });

            foreach (Student std in students)
                Console.WriteLine(std);

            Console.WriteLine("========================================");

            //Also, use another criteria using same delegate
            students = StudentExtension.where(studentArray, delegate (Student std)
            {
                return std.Name == "Bill";
            });

            foreach (Student std in students)
                Console.WriteLine(std);

            Console.WriteLine("========================================");

            // WHY LINQ - EXAMPLE: LINQ

            // Use LINQ to find teenage students
            students = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            foreach (Student std in students)
                Console.WriteLine(std);

            Console.WriteLine("========================================");

            // Use LINQ to find student whose name is Bill
            students = studentArray.Where(s => s.Name == "Bill").ToArray();

            foreach (Student std in students)
                Console.WriteLine(std);

            Console.WriteLine("========================================");

            // Use LINQ to find student whose ID is 5
            students = studentArray.Where(s => s.StudentID == 5).ToArray();
            foreach (Student std in students)
                Console.WriteLine(std);

            // EXAMPLE: LINQ Query Syntax in C#
            // string collection
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };

            Console.WriteLine("===============================================");

            // LINQ Query Syntax
            IEnumerable<string> result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

            foreach (string r in result)
                Console.WriteLine(r);

            Console.WriteLine("================================================");

            // Teenager student with LINQ
            IEnumerable<Student> teenagerStudent = from s in studentArray
                                                   where s.Age > 12 && s.Age < 20
                                                   select s;

            foreach (Student student in teenagerStudent)
                Console.WriteLine(student);

            Console.WriteLine("==================================================");

            // EXAMPLE LINQ METHOD SYNTAX
            result = stringList.Where(s => s.Contains("Tutorials"));
            foreach (string r in result)
                Console.WriteLine(r);

            Console.WriteLine("==================================================");
            // TEENAGER STUDENTS USING METHOD SYNTAX

            teenagerStudent = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToList();
            foreach (Student student in teenagerStudent)
                Console.WriteLine(student);

            Console.WriteLine("==================================================");
            // Example: WHERE CLAUSE - LINQ query syntax C#

            var filteredResult = from s in studentArray
                                 where s.Age > 12 && s.Age < 20
                                 select s.Name;

            foreach (var s in filteredResult)
                Console.WriteLine(s);

            Console.WriteLine("==================================================");

            // Example: WHERE CLAUSE with FUNC
            Func<Student, bool> isTeenAger = delegate (Student s)
             {
                 return s.Age > 12 && s.Age < 20;
             };

            var filteredResult2 = from s in studentArray
                             where isTeenAger(s)
                             select s;

            foreach (var s in filteredResult2)
                Console.WriteLine(s);

            Console.WriteLine("==================================================");

            // WHERE clause with overloaded function IsTeenAger

            var filteredResult3 = from s in studentArray
                                  where isTeenAger(s)
                                  select s.Name;

            foreach (var s in filteredResult3)
                Console.WriteLine(s);

            Console.WriteLine("==================================================");

            // WHERE CLAUSE WITH METHOD SYNTAX
            var filteredResult4 = studentArray.Where(s => s.Age > 12 && s.Age < 20);

            foreach (var s in filteredResult4)
                Console.WriteLine(s);

            Console.WriteLine("==================================================");
            // WHERE EXTENSION METHOD IN C#
            
            var filteredResult5 = studentArray.Where((s, x) =>
            {
                if (x % 2 == 0)
                    return true;

                return false;
            });

            foreach (var s in filteredResult5)
                Console.WriteLine(s.Name);
            Console.WriteLine("==================================================");

            // MULTIPLE WHERE CLAUSE

            var filteredResult6 = from s in studentArray
                                  where s.Age > 12
                                  where s.Age < 20
                                  select s;

            foreach (var s in filteredResult5)
                Console.WriteLine(s);

            Console.WriteLine("==================================================");


            // EXAPLE: OfType operator in C#

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student("Gogu", 19));

            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;

            Console.WriteLine("String results");
            foreach (var s in stringResult)
                Console.WriteLine(s);

            Console.WriteLine("Integer results");
            foreach (var s in intResult)
                Console.WriteLine(s);

            Console.WriteLine("=====================================================");

            // EXAMPLE: OfType in Method Syntax
            stringResult = mixedList.OfType<string>();
            intResult = mixedList.OfType<int>();

            Console.WriteLine("String results");
            foreach (var s in stringResult)
                Console.WriteLine(s);

            Console.WriteLine("Integer results");
            foreach (var s in intResult)
                Console.WriteLine(s);

            Console.WriteLine("=====================================================");

            Console.ReadKey();
        }

        public static bool isTeenAger(Student stud)
        {
            return stud.Age > 17 && stud.Age < 20;
        }
    }
}
