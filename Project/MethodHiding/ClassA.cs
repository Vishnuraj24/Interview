using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class ClassA
    {
        public virtual void Show()
        {
            Console.WriteLine("Show from the classA Show");
        }


    }

    public class ClassB : ClassA
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Show from the classB Show");

        }
    }

}
