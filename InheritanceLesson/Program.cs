using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student();
            /*((Student)student).ToDo();
            (student as Student).ToDo();

            if (student is Mentor)
            {
                (student as Mentor).SayFirstName();
            }
            else if(student is Student)
            {
                (student as Student).ToDo();
            }*/

            Console.WriteLine(student);
            
        }
    }
}
