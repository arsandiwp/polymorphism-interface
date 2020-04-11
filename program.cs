using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Arsandi", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Wira", 30, "191128", "May");
            teacher.GetNameAndAge();

            Student student = new Student("Panorama", 19, "2822", "arsandi.08@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}