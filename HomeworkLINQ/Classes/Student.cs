using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLINQ.Classes
{
    class Student
    {
        private static int studentId = 0;
        public int StudentID { get; }
        public string Name { get; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            StudentID = ++studentId;
        }

        public override string ToString()
        {
            StringBuilder studentData = new StringBuilder();
            studentData.Append($"ID: {StudentID}\n");
            studentData.Append($"Name: {Name}\n");
            studentData.Append($"Age: {Age}\n");

            return studentData.ToString();
        }
    }
}
