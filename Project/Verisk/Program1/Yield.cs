using System;
using System.Collections.Generic;

class Yield
{
   
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static IEnumerable<int> GetPrimes(List<int> nums)
    {
        foreach (int n in nums)
        {
            if (IsPrime(n))
                yield return n;  // Only return if it’s prime
        }
    }
}
