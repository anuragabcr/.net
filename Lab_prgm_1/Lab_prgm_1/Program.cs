using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_prgm_1
{
    public class Student
    {
        public string FullName { get; set; }
        public int Semester { get; set; }
        public string CourseCode { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Student()
        {
        }

        public Student(string fullName, int semester, string courseCode, string subject, string email, string phoneNumber)
        {
            FullName = fullName;
            Semester = semester;
            CourseCode = courseCode;
            Subject = subject;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Student(string fullName, int semester, string courseCode)
        {
            FullName = fullName;
            Semester = semester;
            CourseCode = courseCode;
            Console.Write("Enter subject:- ");
            Subject = Console.ReadLine();
            Console.Write("Enter Email:- ");
            Email = Console.ReadLine();
            Console.Write("Enter Phone number:- ");
            PhoneNumber = Console.ReadLine();
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("Course Code: " + CourseCode);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John Doe", 3, "CS101", "Computer Science", "john@example.com", "1234567890");
            Student student2 = new Student("Jane Smith", 2, "ENG202");
            Student student3 = new Student();

            student1.DisplayInformation();
            Console.WriteLine();

            student2.DisplayInformation();
            Console.WriteLine();

            student3.DisplayInformation();
            Console.ReadLine();
        }
    }
}
