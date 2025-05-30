// See https://aka.ms/new-console-template for more information
using ADO.DataAccess_ADO;

Console.WriteLine("Hello, World!");


DataAccess dataAccess = new DataAccess();
//dataAccess.GetData();
//dataAccess.GetDataById(4);
//dataAccess.GetCount();

dataAccess.UpdateEmployee(51, 5600.40);