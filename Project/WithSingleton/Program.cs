using WithSingleton;

Console.WriteLine("With the singleton pattern");

//DatabaseConnection.GetInstance();
//DatabaseConnection.GetInstance();
//DatabaseConnection.GetInstance();

Parallel.Invoke(
           () => TestSingleton1(),
           () => TestSingleton1(),
           () => TestSingleton1(),
           () => TestSingleton1()
       );


//output : 
//New Database Connection is created


Console.WriteLine("With the singleton pattern with the thread safety");


Parallel.Invoke(
           () => TestSingleton(),
           () => TestSingleton(),
           () => TestSingleton(),
           () => TestSingleton()
       );

static void TestSingleton()
{
    var instance = ThreadSafety.GetInstance();
    Console.WriteLine($"Instance HashCode: {instance.GetHashCode()}");
}

static void TestSingleton1()
{
    var instance = DatabaseConnection.GetInstance();
    Console.WriteLine($"Instance HashCode: {instance.GetHashCode()}");
}



/*
 OUTPUT : 
---------------------------------------------------------------------
 With the singleton pattern
New Database Connection is created
New Database Connection is created
Instance HashCode: 43942917
New Database Connection is created
New Database Connection is created
Instance HashCode: 45653674
Instance HashCode: 62476613
Instance HashCode: 12547953
With the singleton pattern with the thread safety
New Connection Created
Instance HashCode: 59941933
Instance HashCode: 59941933
Instance HashCode: 59941933
Instance HashCode: 59941933
 
 ----------------------------------------------------------------------
 
 */