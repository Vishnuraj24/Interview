using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSingleton
{
    public class ThreadSafety
    {
        private static ThreadSafety _instance;
        private static object _lock = new object();
        private ThreadSafety()
        {
            Console.WriteLine("New Connection Created");
        }

        public static ThreadSafety GetInstance()
        {
            try
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafety();
                    }
                    return _instance;
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }


    }
}
