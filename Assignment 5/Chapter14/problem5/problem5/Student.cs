using System;
using System.Collections.Generic;
using System.Text;

namespace problem5
{
    public class Student
    {
        Student()
        {
            this.Course = null;
            this.Email = null;
            this.FullName = null;
            this.Phone = 0;
            this.Subject = null;
        }
        Student(string course)
        {
            this.Course = course;
            this.Email = null;
            this.FullName = null;
            this.Phone = 0;
            this.Subject = null;
        }
        Student(string course, string email)
        {
            this.Course = course;
            this.Email = email;
            this.FullName = null;
            this.Phone = 0;
            this.Subject = null;
        }
        Student(string course, string email, string fullname)
        {
            this.Course = course;
            this.Email = email;
            this.FullName = fullname;
            this.Phone = 0;
            this.Subject = null;
        }
        Student(string course, string email, string fullname, long number)
        {
            this.Course = course;
            this.Email = email;
            this.FullName = fullname;
            this.Phone = number;
            this.Subject = null;
        }
        Student(string course, string email, string fullname, long number, string subject)
        {
            this.Course = course;
            this.Email = email;
            this.FullName = fullname;
            this.Phone = number;
            this.Subject = subject;
        }

        const string university = "XYZ university";
        string FullName { get; set; }
        string Course { get; set; }
        string Subject { get; set; }
        string Email { get; set; }
        long Phone { get; set; }

        public void PrintInfo(Student student)
        {
            Console.WriteLine(student.FullName + student.Course + student.Email + student.Phone + student.Subject + university);
        }
    }
}
