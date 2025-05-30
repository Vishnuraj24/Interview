using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSingleton
{
    //With Singleton Pattern
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance; //static Instance
        private DatabaseConnection() {
            Console.WriteLine("New Database Connection is created");
        }

        public static DatabaseConnection GetInstance()
        {
            if(_instance == null)
            {
                _instance = new DatabaseConnection();
            }
            return _instance;
        }

        public void Connect()
        {
            Console.WriteLine("Database connected");
        }
    }
}
