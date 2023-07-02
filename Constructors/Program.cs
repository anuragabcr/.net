using System;

class Student
{
    string fullName;
    int semester;
    string courseCode;
    string subject;
    string email;
    string phoneNumber;

    public Student(string fullName, int semester, string courseCode, string subject, string email, string phoneNumber)
    {
        this.fullName = fullName;
        this.semester = semester;
        this.courseCode = courseCode;
        this.subject = subject;
        this.email = email;
        this.phoneNumber = phoneNumber;
    }

    public Student(string fullName, int semester, string courseCode)
    {
        this.fullName = fullName;
        this.semester = semester;
        this.courseCode = courseCode;
        this.subject = null;
        this.email = null;
        this.phoneNumber = null;
    }

    public void Display()
    {
        Console.WriteLine("Name: {0}\nSemester: {1}\nCourse Code: {2}\nSubject: {3}\nEmail: {4}\nPhone Number: {5}", fullName, semester, courseCode, subject ?? "Not specified", email ?? "Not specified", phoneNumber ?? "Not specified");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("John Doe", 3, "CS101", "Computer Science", "john.doe@example.com", "555-1234");
        Student student2 = new Student("Jane Smith", 2, "PH201");
        student1.Display();
        Console.WriteLine();
        student2.Display();
    }
}
