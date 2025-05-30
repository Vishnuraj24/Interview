// See https://aka.ms/new-console-template for more information
using WithoutSingleton;

Console.WriteLine("Before SingleTon Pattern");
//every time an object is created which reduce the performance and speed

DatabaseConnection db1 = new DatabaseConnection();
DatabaseConnection db2 = new DatabaseConnection();
DatabaseConnection db3 = new DatabaseConnection();

