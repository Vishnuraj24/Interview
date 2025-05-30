using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class A
    {
        public void ABC(int x)
        {
            Console.WriteLine("ABC from class A");
        }
    }
    class B :A {
        public void ABC(double x) {

            Console.WriteLine("ABC from the class B");
        }
    } 
}
