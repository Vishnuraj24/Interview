// See https://aka.ms/new-console-template for more information
using SolidPrinciples;

Console.WriteLine("Hello, World!");
Billings billings = new Billings();
Book book = new Book();
billings.CalculatePrice(book);