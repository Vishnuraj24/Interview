using WithAdapter;

IPrinter printer1 = new NewPrinter();
IPrinter printer2 = new OldPrinterAdapter(new OldPrinter());

Console.WriteLine("New Printer");
printer1.PrintDocument();

Console.WriteLine("Old Printer => PrintDocument");
printer2.PrintDocument();