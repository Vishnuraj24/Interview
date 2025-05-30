using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Delegate
{
    public class MyMethods
    {
        public static double Add(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void Mul(int x, int y)
        {
            Console.WriteLine($"The Action Result is : {x*y}");
        }

        public static bool PrimeorNot(int x)
        {
            bool flag = false;
            for(int i = 2; i <= x/2; i++)
            {
                if(x % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                return false;
            }
            return true;
        }

    }
    public class BuiltinDelegates
    {
        public static void MyBuiltinDelegates()
        {
            Func<int, float, double, double> func = MyMethods.Add;
            double funcres = func(20, (float)10.955, 11.65);
            Console.WriteLine($"Func result : {funcres}");

            Action<int,int> action = MyMethods.Mul;

            Predicate<int> predicate = MyMethods.PrimeorNot;
            
            int num = 7;
            Console.WriteLine($"The {num} is prime? : {predicate(num)}");



        }
    }
}
