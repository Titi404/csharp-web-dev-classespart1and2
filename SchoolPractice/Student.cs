using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        private static int nextStudentId = 0;
        public int NumberOfCredits { get; set; } = 0;
        public double Gpa { get; set; }





        public Student(string name, int numberOfCredits, double gpa)
        {
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
            StudentId = nextStudentId++;


        }


    }



}
