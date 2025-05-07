using System;
using System.Threading;

class CounterWithoutLock
{
    private readonly object _lockObj;
    public int Count = 0;

    public void Increment()
    {
        for (int i = 0; i < 10000; i++)
        {
            Count++;  // No lock, multiple threads may access at same time!

            //lock (_lockObj)
            //{
            //    Count++; // Thread-safe increment
            //}

        }
    }
}

/*
 🔐 What is lock in C#?
=> The lock statement prevents multiple threads from accessing a critical section of code at the 
same time.

=> It ensures that only one thread at a time can enter the lock block, protecting shared resources 
from race conditions.
 
💥 Why we need lock?
In multithreaded applications, if multiple threads try to read/write shared data at the same time,
it can lead to:

->Incorrect data

->Unexpected behavior

->Crashes

The lock helps us avoid these problems.

🧯 What happens if an exception is thrown inside lock?
Good news — the lock is automatically released even if an exception is thrown inside the lock block. 
You don’t need to release it manually.

 */