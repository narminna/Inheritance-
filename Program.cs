using System;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }
    }
    public class Student : Person 
    {
        public Student(string name, string surname, int age):base(name, surname, age)
        {

        }
        public void Learn()
        {
            Console.WriteLine("Learning...");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Araz", "Yusubov", 48);
            Student student = new Student("Ali", "Aliyev", 18);

            Console.WriteLine(teacher.Name + " " + teacher.Surname + " " + teacher.Age);
            Console.WriteLine(student.Name + " " + student.Surname + " " + student.Age);
            teacher.Explain();
            student.Learn();
        }
    }
}