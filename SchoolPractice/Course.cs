using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public List<Student> EnrolledStudents { get; set; }
        public string Subject { get; set; }
        public int CourseCredits { get; set; }
        public Teacher CourseInstructor { get; set; }
        public int CourseId { get; set; }
        public static int nextCourseId = 0;


        public Course (List<Student> enrolledStudents, string subject, int courseCredits, Teacher courseInstructor)
        {
            EnrolledStudents = enrolledStudents;
            Subject = subject;
            CourseCredits = courseCredits;
            CourseInstructor = courseInstructor;
            CourseId = nextCourseId++;
        }



    }
}
