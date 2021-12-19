using System;
using System.Collections.Generic;
using System.Text;

namespace Practise6
{
    class Student
    {
        public string FullName { get; set; }
        public string Course { get; set; }
        public string Subject { get; set; }
        public string University { get; set; }
        private string _email { get; set; }
        private string _phoneNumber { get; set; }

        public Student()
        {
            
        }

        public Student(string name, string surname, string course, string subject, string university, string email, string phone):this()
        {
            FullName = name + " " + surname;
            Course = course;
            Subject = subject;
            University = university;
            _email = email;
            _phoneNumber = phone;

            Info();
        }

        public void Info()
        {
            Console.WriteLine("About the student:");
            Console.WriteLine($"Name, Surname: {FullName}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"University: {University}");
            Console.WriteLine($"Email: {_email}");
            Console.WriteLine($"Phone number: {_phoneNumber}");
        }
    }
}
