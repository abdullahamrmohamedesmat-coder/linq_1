using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced03
{
    internal class Student
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
             Student student = obj as Student;
            return Name== student.Name && Age == student.Age;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
    public record StudentRecord(string Name ,int Age);
}
