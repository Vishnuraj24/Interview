using MethodHiding;

//ClassB b = new ClassB();
//b.Show();           // Output: Show from B

//ClassA a = new ClassB();
//a.Show();           // Output: Show from A (❗)


int x = 2;
B b = new B();
b.ABC(x);