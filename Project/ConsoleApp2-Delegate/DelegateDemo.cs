using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Delegate
{
    delegate void PrintDelegate(string message);
    public class DelegateDemo
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void TestMethod() {
            PrintDelegate printDelegate = PrintMessage;
            printDelegate("Hi vishnuraj Kandukuri");
        }
    }
}
