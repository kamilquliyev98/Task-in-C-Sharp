using System;
using System.Collections.Generic;
using System.Text;

namespace Education
{
    class Person
    {
        protected int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hi everyone!");
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
