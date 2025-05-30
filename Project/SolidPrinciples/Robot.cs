using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //Demonstration of the INTERFACE SEGREGATION PRINCIPLE

    /*Dont force the clases to implement the methods which are not used by the classes*/

    /*Below code violates the ISP */

   
    interface IWorkable
    {
        void Eat() { }
        void Sleep() { }
        void Work() { }
    }
    public class Robot : IWorkable
    {
        //Here Robot cannot sleep and eat but we inheriting from the interface then we need 
        //definately implement.

        public void Work() { }
        public void Sleep() { throw new NotImplementedException(); }
        public void Eat() { throw new NotImplementedException(); }
    }
}
