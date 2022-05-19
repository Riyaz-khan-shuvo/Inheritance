using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Person
    {
       public string name;
       public int age;
        public static int numberOfPerson = 0;
        
        public  void Display()
        {
            Console.WriteLine("Your Name is : "+ name + " Your Age is : " + age);
        }

       //public Person(string _name , int _age)
       // {
       //     name = _name;
       //     age = _age;
       //     numberOfPerson++;
       // }
    }

     class Student :  Person 
    {
        public int id;
        public void  Displays()
        {
            Console.WriteLine("Your Name is : " + name + " Your Age is : " + age + " And Your Id is : " + id);
        }

        public Student(string _names , int _ages , int _id)
        {
            name = _names;
            age= _ages;
            id = _id;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");

            //Person riyaz = new Person("Riyaz Khan Shuvo" , 18);

            //riyaz.Display();

            //Person shuvo = new Person("Shuvo Khan", 23);
            //shuvo.Display();

            //Console.WriteLine("Total Person : " + Person.numberOfPerson);

            Student riyaz1 = new Student("Riyaz Khan" , 19 , 1901017);

            riyaz1.Displays();

            Console.ReadLine(); 
        }
    }
}
