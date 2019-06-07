using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudentsLINQ.Classes
{
    class RunAll
    {
        public static void Queries(IEnumerable<Student> students, List<Group> groups)
        {
            // First before last
            PrintingClass.FirstBeforeLast(students);
            PrintingClass.PrintNext();
            // Age Range
            PrintingClass.AgeRange(students);
            PrintingClass.PrintNext();
            // Order Students
            PrintingClass.OrderStudents(students);
            PrintingClass.PrintNext();
            // Order Students LINQ
            PrintingClass.OrderStudentsLINQ(students);
            // Student Groups
            PrintingClass.StudentGroups(students);
            PrintingClass.PrintNext();
            // Student Groups LINQ
            PrintingClass.StudentGroupsLINQ(students);
            PrintingClass.PrintNext();
            // Students by phone
            PrintingClass.StudentsByPhone(students);
            PrintingClass.PrintNext();
            // Students with Excellent Marks
            PrintingClass.StudentsByMarks(students);
            PrintingClass.PrintNext();
            // Students with Two Marks
            PrintingClass.StudentsWithTwoMarks(students);
            PrintingClass.PrintNext();
            // Extract Marks
            PrintingClass.ExtractMarks(students);
            PrintingClass.PrintNext();
            // Groups
            PrintingClass.Groups(students, groups);
            PrintingClass.PrintNext();
            // Grouped by group number
            PrintingClass.GroupedByGroupNumber(students);
            PrintingClass.PrintNext();
            // Grouped by group number LINQ
            PrintingClass.GroupedByGroupNumberLINQ(students);
            PrintingClass.PrintNext();
        }
    }
}
