using System;

namespace Program1
{
    public class BaseClass
    {
        static BaseClass()
        {
            Console.WriteLine("Base Static Constructor");
        }

        public BaseClass()
        {
            Console.WriteLine("Base Default Constructor");
        }

        public BaseClass(string msg)
        {
            Console.WriteLine("Base Parameterized Constructor: " + msg);
        }
    }

    public class DerivedClass : BaseClass
    {
        private static DerivedClass instance = new DerivedClass("From Static Field");

        static DerivedClass()
        {
            Console.WriteLine("Derived Static Constructor");
        }

        private DerivedClass(string msg) : base("Called from Derived")
        {
            Console.WriteLine("Derived Private Constructor: " + msg);
        }

        public DerivedClass() : base()
        {
            Console.WriteLine("Derived Default Constructor");
        }

        public DerivedClass(int x) : base("From Parameterized")
        {
            Console.WriteLine("Derived Parameterized Constructor: " + x);
        }

        public static void CreateInstance()
        {
            Console.WriteLine("Static method accessed");
        }
    }

    
}
