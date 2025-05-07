using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    // Demonstration of Open/Closed Principle

    /*Classes should be open for the extension not for the modification of the existing classes*/

    /*if any new itemtype added we need to modify original code and test complete class code*/
    class Billing
    {
        // Below code Violates the Open/Closed Principle
        public double CalculatePrice(string itemType)
        {
            if(itemType == "CD") { return 500; }
            else if (itemType == "Book") { return 800; }
            else { return 0; }
        }

    }


    //What we need to do ? Idea => implement INTERFACES.
    //instead of modifying we are extending.
    public interface IProduct
    {
        public double getPrice();
    }

    class Book : IProduct
    {
        public double getPrice()
        {
            return 800;
        }
    }

    class CD : IProduct
    {
        public double getPrice()
        {
            return 500;
        }
    }

    public class Billings
    {
        public double CalculatePrice(IProduct product)
        {
            return product.getPrice();
        }
    }
}
