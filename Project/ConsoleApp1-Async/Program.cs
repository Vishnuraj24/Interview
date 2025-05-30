using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Async
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Asynchronous Programming Demo");
            // Start Method1 and Method3 asynchronously
            var t1 = Method1(); // 3 seconds
            var t3 = Method3(); // 1 second

            // Method2 runs synchronously in between
            Method2(); // no delay

            // Now await both async methods to finish
            await Task.WhenAll(t1, t3);

            //int[] arr = { 6, 9, 1, 5, 7, 2, 12 };
            //Console.WriteLine(string.Join(", ", arr));
            //Bubble_Sort(arr);
            //Console.WriteLine(string.Join(", ",arr));

        }

        public static async Task Method1()
        {
            Console.WriteLine("Method1 started executing");
            await Task.Delay(5000);
            Console.WriteLine("Method1 Completed executing");

        }
        public static void Method2()
        {
            Console.WriteLine("Method2 started executing");
         
            Console.WriteLine("Method2 Completed executing");

        }

        public static async Task Method3()
        {
            Console.WriteLine("Method3 started executing");
            await Task.Delay(1000);
            Console.WriteLine("Method3 Completed executing");

        }

        public static void Bubble_Sort(int[] arr)
        {
            for(int i = 0;i < arr.Length - 1; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;

                    }
                }
            }
        }
    }
}
