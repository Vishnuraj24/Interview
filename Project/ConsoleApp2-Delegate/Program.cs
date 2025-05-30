// See https://aka.ms/new-console-template for more information
using ConsoleApp2_Delegate;
using MulticastDelegate = ConsoleApp2_Delegate.MulticastDelegate;

Console.WriteLine("Hello, World!");
DelegateDemo.TestMethod();

Console.WriteLine("Multicast Delegates");
MulticastDelegate.MyMethod();

Console.WriteLine("Builtin Delegates");
BuiltinDelegates.MyBuiltinDelegates();