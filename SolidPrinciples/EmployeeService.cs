using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{

    /*Demonstration Of DEPENDENCY INVERSION PRINCIPLE*/

    //High Modules should not depend on the Low level modules instead depend on the Abstraction(interfaces)
    public class MySQLDatabase1
    {
        public void Save() { /*LOGIC FOR SAVING EMPLOYEE IN THE MYSQL DATABASE*/}
    }
    public class EmployeeService1
    {
        public EmployeeService1() { }

        private MySQLDatabase1 db = new MySQLDatabase1();

        public void SaveEmployee()
        {
            db.Save();
        }
    }


    //for suppose we got a requirement to save the data in the sql server then as the object
    //is tightly coupled then it we need to modify the many places and need to test whole class and
    //and it will be hectic and difficult

    //we follow the principle like below

    public interface IDatabase
    {
        void Save();
    }

    public class SQLServer:IDatabase
    {
        public void Save()
        {
            /*LOGIC TO SAVE EMPLOYEE IN THE SQL SERVER DATA BASE*/
        }
    }

    /*builder.services.AddScoped<IDataBase,SQLServer>();*/

    public class EmployeeService2
    {
        private readonly SQLServer _server;
        public EmployeeService2(SQLServer server) {
            _server = server;
        }

        public void SaveEmployee() { 
            _server.Save();
        }

}
