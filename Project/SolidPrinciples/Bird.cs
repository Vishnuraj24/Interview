using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //Demonstration of the LISKOV SIBSTITUTION PRINCIPLE

    /*A child class should replace the parent class with out Breaking the code*/

    // Below code violates the LISKOV SUBSITUTION PRINICIPLE
    public class Bird
    {
        public string Name { get; set; }
        public void Fly() { /*LOGIC FOR FLY*/}

    }

    public class Ostrich : Bird { } // But Ostrich Cannot FLY!!!

    //Below code follows the LISKOV SUBSTITUTION PRINCIPLE

    public abstract class Birds { 
        public string Name { get; set; }
    }

    public interface IFlyable
    {
        public void FLy();
    }

    public class Ostrichh : Birds {
        public string Name = "Ostrich";

        //No fly method
    }

}
