using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Delegate
{
    public delegate void MyDelegate(int x, int y);
    public delegate bool MyPrimeDelegate(int num);
    public class MulticastDelegate
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition: {x + y}");
        }

        public static void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication : {x*y}");
        }

        public static bool PrimeOrNot(int x)
        {
            bool isprime = true;
            for (int i = 2; i <= x / 2; i++) {
                if (x % i == 0) { 
                    isprime = false; break;
                }
            }
            return isprime;
        }

        public static void MyMethod()
        {
            MyDelegate myDelegate = Add;
            myDelegate += Mul;
            myDelegate(5, 6);

            MyPrimeDelegate d = PrimeOrNot;
            //passing a method as a parameter
            ClassA.Method1(8, d);
        }
    }

    public class ClassA
    {
        public static void Method1(int a, MyPrimeDelegate d)
        {

            if (d(a))
            {
                Console.WriteLine($" {a} Yes it is a Prime Number");
            }
            else
            {
                Console.WriteLine($" {a} No it is not a Prime Number");
            }

        }
    }
}
