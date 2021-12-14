using System;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            Person person = new Person();

            student.Study();
            teacher.Explain();
            person.Greet();

            student.SetAge(23);
            student.ShowAge();

            teacher.SetAge(32);
        }
    }
}