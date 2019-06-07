﻿using System;
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

            // First before last
            PrintingClass.FirstBeforeLast(students);
            // Age Range
            PrintingClass.AgeRange(students);
            // Order Students
            PrintingClass.OrderStudents(students);
            // Order Students LINQ
            PrintingClass.OrderStudentsLINQ(students);
            // Student Groups
            PrintingClass.StudentGroups(students);
            // Student Groups LINQ
            PrintingClass.StudentGroupsLINQ(students);
            // Students by phone
            PrintingClass.StudentsByPhone(students);
            // Students with Excellent Marks
            PrintingClass.StudentsByMarks(students);
            // Students with Two Marks
            PrintingClass.StudentsWithTwoMarks(students);
            // Extract Marks
            PrintingClass.ExtractMarks(students);
            // Groups
            PrintingClass.Groups(students, groups);
            // Grouped by group number
            PrintingClass.GroupedByGroupNumber(students);
            // Grouped by group number LINQ
            PrintingClass.GroupedByGroupNumberLINQ(students);

            Console.ReadKey();
        }

    }
}
