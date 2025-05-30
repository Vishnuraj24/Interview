using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Class2
    {
        public Class2()
        {
            Console.WriteLine("Iam the default constructor of the class2(base class)");
        }

        public Class2(string name)
        {
            Console.WriteLine($"Hi! {name}, Iam the paramter constructor of the class2(base class)");
        }
    }

    public class Class3 : Class2
    {
        public Class3(string name) :base(name) 
        {
            Console.WriteLine($"Hi {name} this is the parameter constructor from class3");            
        }
    }
    
}
