using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutSingleton
{
    //Before the Singleton pattern
    public class DatabaseConnection
    {
        public DatabaseConnection()
        {
            Console.WriteLine("New Database Connection is created");
        }

        public void Connect()
        {
            Console.WriteLine("Connected to the Database");
        }
    }
}
