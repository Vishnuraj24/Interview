using System;

namespace Program1
{
    // Parent class
    public class Person
    {
        public string Name;

        // Base class constructor
        public Person(string name)
        {
            Name = name;
            Console.WriteLine("Base constructor called - Name: " + name);
        }
    }

    // Derived class
    public class Student : Person
    {
        public int Age;

        // Constructor chaining to another constructor in same class using this()
        public Student() : this("DefaultName", 18)
        {
            Console.WriteLine("Default constructor of Student called");
        }

        // Constructor that also calls base class constructor using base()
        public Student(string name, int age) :base(name) 
        {
            Age = age;
            Console.WriteLine($"Student constructor called - Age: {age}");
        }
    }

    
}
