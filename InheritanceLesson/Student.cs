using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public class Student : Person
    {
        public Student() : base("", "", "")
        { }
        

        public Student(string firstName, string secondName, string lastName, string group, double averageMark) : base(firstName, secondName, lastName)
        {
            Group = group;
            AverageMark = averageMark;
        }

        public string Group { get; set; }

        public double AverageMark { get; set; }

        public override void SayPosition()
        {
            
        }

        public void ToDo() { }

        /*public override string ToString()
        {
            return $"{FirstName} {SecondName} {LastName}";
        }*/

    }
}
