using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }



        public Person(string firstName, string secondName, string lastName)
        {
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
        }

        public virtual void SayFullName()
        {
            Console.WriteLine($"{FirstName} {SecondName} {LastName}");
        }

        public void SayFirstName()
        {
            Console.WriteLine($"{FirstName}");
        }

        //abstract - ключевое слово, которое обозначает, что метод (член) обязан быть определен у каждого наследника 
        public abstract void SayPosition();

       
    }
}
