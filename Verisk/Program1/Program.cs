// See https://aka.ms/new-console-template for more information

using Program1;

//Console.WriteLine("Hello, World!");

//ClassA classA = new ClassB("S");
//Test.Method();

//Student student = new Student("defaultname" ,19);

//Class3 class3 = new Class3("Vishnuraj");


// Uncomment only one at a time to see execution clearly

////DerivedClass.CreateInstance();
//Console.WriteLine("====================================================================\n");
////DerivedClass d = new DerivedClass();
//Console.WriteLine("====================================================================\n");
//DerivedClass d2 = new DerivedClass(10);

//CounterWithoutLock counter = new CounterWithoutLock();

//Thread t1 = new Thread(counter.Increment);
//Thread t2 = new Thread(counter.Increment);
//Thread t3 = new Thread(counter.Increment);



//t1.Start();
//t2.Start();
//t3.Start();

//t1.Join(); // wait for threads to finish
//t2.Join();
//t3.Join(); // wait for threads to finish


//Console.WriteLine("Final Count (without lock): " + counter.Count); // ❌ Wrong result expected


List<int> numbers = new List<int>() { 2, 4, 5, 9, 11, 14, 17, 19 };

foreach (int prime in Yield.GetPrimes(numbers))
{
    Console.WriteLine("Prime: " + prime);
}