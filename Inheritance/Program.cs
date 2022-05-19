using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Person
    {
        string name;
        int age;
        public static int numberOfPerson = 0;
        
        public  void Display()
        {
            Console.WriteLine("Your Name is : "+ name + " Your Age is : " + age);
        }

       public Person(string _name , int _age)
        {
            name = _name;
            age = _age;
            numberOfPerson++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");

            Person riyaz = new Person("Riyaz Khan Shuvo" , 18);

            riyaz.Display();

            Person shuvo = new Person("Shuvo Khan", 23);
            shuvo.Display();

            Console.WriteLine("Total Person : " + Person.numberOfPerson);

            Console.ReadLine(); 
        }
    }
}
