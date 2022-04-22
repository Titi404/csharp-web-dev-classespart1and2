using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student titi = new Student("Titi the Cat", 1, 4.0);
            Student harry = new Student("Harry Potter", 4, 4.0);
            Student malfoy = new Student("Draco Malfoy", 0, 0.0);
            Teacher snape = new Teacher("Severus", "Snape", "Potion", 11);

            List<Student> studentInPotion = new List<Student>();
            studentInPotion.Add(titi);
            studentInPotion.Add(harry);
            studentInPotion.Add(malfoy);


            Course potions101 = new Course(studentInPotion, "Potion and Alchemy", 1000, snape);


            foreach (Student pupil in studentInPotion)
            { 
                Console.WriteLine(pupil.Name);
            }

            //Console.WriteLine($"Name:{titi.Name} GPA: {titi.Gpa} Credit: {titi.NumberOfCredits} ");
            //Console.WriteLine($"Name:{harry.Name} GPA: {harry.Gpa} Credit: {harry.NumberOfCredits} ");


        }
    }
}
