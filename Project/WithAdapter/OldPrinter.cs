using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithAdapter
{
    public interface IPrinter
    {
        public void PrintDocument() { }
    }
    public class OldPrinter
    {
        public void PrintPage()
        {
            Console.WriteLine("Printing Page from Old Printer");
        }
    }

    public class NewPrinter : IPrinter
    {
        public void PrintDocument() { Console.WriteLine("Printing Document from the New Printer"); }
    }

    //inorder to use the PrintDocument with the old printer we use with the Adapterclass.

    public class OldPrinterAdapter : IPrinter
    {
        private readonly OldPrinter _printer;
        public OldPrinterAdapter(OldPrinter printer)
        {
            _printer = printer;
        }

        public void PrintDocument() {
            _printer.PrintPage();
        }
    }



}
