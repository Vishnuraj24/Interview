using System;

namespace Program1
{
    class Test
    {
        public static void Method()
        {
            string validNumber = "123";
            string nullString = null;
            string invalidString = "abc";

            // ✅ Example with valid string
            Console.WriteLine("=== Valid String ===");
            Console.WriteLine("Parse: " + Int32.Parse(validNumber));               // ✅ 123
            Console.WriteLine("Convert: " + Convert.ToInt32(validNumber));         // ✅ 123

            // ❌ Example with null string
            Console.WriteLine("\n=== Null String ===");
            try
            {
                Console.WriteLine("Parse: " + Int32.Parse(nullString));           // ❌ Throws ArgumentNullException
            }
            catch (Exception ex)
            {
                Console.WriteLine("Parse Exception: " + ex.Message);
            }

            Console.WriteLine("Convert: " + Convert.ToInt32(nullString));          // ✅ Returns 0

            // ❌ Example with invalid string
            Console.WriteLine("\n=== Invalid String ===");
            try
            {
                Console.WriteLine("Parse: " + Int32.Parse(invalidString));         // ❌ Throws FormatException
            }
            catch (Exception ex)
            {
                Console.WriteLine("Parse Exception: " + ex.Message);
            }

            try
            {
                Console.WriteLine("Convert: " + Convert.ToInt32(invalidString));   // ❌ Throws FormatException
            }
            catch (Exception ex)
            {
                Console.WriteLine("Convert Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
