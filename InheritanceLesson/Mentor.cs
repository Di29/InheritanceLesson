using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public class Mentor : Person
    {
        public string SubjectName { get; set; }

        public Mentor(string firstName, string secondName, string lastName, string subjectName) :base(firstName, secondName, lastName)
        {
            SubjectName = subjectName;
        }

        //override - ключевое слово, которое обозначает, что метод (член) базового класса переопределен здесь
        public override void SayFullName()
        {
            Console.WriteLine($"{FirstName} {SecondName} {LastName} {SubjectName}");
        }

        //new - ключевое слово, которое обозначает, что метод (член) базового класса переопределен здесь,
        //но у родителя есть общий на всех подобный метод
        public new void SayFirstName()
        {
            base.SayFirstName();
            Console.WriteLine($"{FirstName} ");
        }

        public override void SayPosition()
        {
               
        }


    }
}
