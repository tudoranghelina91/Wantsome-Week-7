using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudentsLINQ.Classes
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public enum Genders { Male, Female };
        public Genders Gender { get; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public List<float> Marks { get; set; } = new List<float>();
        public int GroupNumber { get; set; }

        private int EnrollmentYear;

        private static Random rnd = new Random();

        public override int GetHashCode()
        {
            int fn = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (i == 5)
                    fn = fn * 10 + (EnrollmentYear / 10 % 10);

                else if (i == 6)
                    fn = fn * 10 + (EnrollmentYear % 10);

                else
                    fn = fn * 10 + rnd.Next(0, 9);
            }

            return fn;
        }

        public Student(string firstName, string lastName, Genders gender, int age, int groupNumber, int enrollmentYear, string tel = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Tel = tel;
            GroupNumber = groupNumber;
            EnrollmentYear = enrollmentYear;
            FN = GetHashCode();
        }
    }
}
