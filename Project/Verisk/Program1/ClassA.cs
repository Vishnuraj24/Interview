using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("V");
        }
        public ClassA(string name) {
            Console.WriteLine("I" + name);
        }
    }

    public class ClassB:ClassA
    {
        public ClassB()
        {
            Console.WriteLine("V");
        }
        public ClassB(string name)
        {
            Console.WriteLine("I" + name);
        }
    }


}
