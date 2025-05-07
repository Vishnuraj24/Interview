using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutAdapter
{
    public class OldPrinter
    {
        public static void PrintPage() {
            Console.WriteLine("Printing Page from Old Printer");
        }
    }

    public class NewPrinter
    {
        public static void PrintDocument()
        {
            Console.WriteLine("Printing Document from the New Printer");
        }
    }

    public class PrintDevice
    {
        public void Print(string PrinterType) 
        {
            if (PrinterType == "old") { OldPrinter.PrintPage(); }
            else if(PrinterType == "new") { NewPrinter.PrintDocument(); }

        }
    }
}
