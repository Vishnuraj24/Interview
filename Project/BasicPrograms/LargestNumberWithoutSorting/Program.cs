
//declaring an array

int[] arr = new int[5] { 25, 87, 23, 2, 46 };

int largest = -1;

for(int i = 0; i < arr.Length; i++)
{
    largest = Math.Max(largest, arr[i]);
}

Console.WriteLine("Largest Number " + largest);

/*Finding the second largest number*/

int secondlargest = -1;

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] > secondlargest && arr[i] != largest)
    {
        secondlargest = arr[i];
    }
}

Console.WriteLine("SecondLargest Number : " + secondlargest);

/*Finding the Third largest number*/

int thirdlargest = -1;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > thirdlargest && arr[i] != secondlargest && arr[i] != largest)
    {
        thirdlargest = arr[i];
    }
}

Console.WriteLine("ThirdLargest Number : " + thirdlargest);

dbcontext.employees.Where(e => e.Age > 18 && e.Age < 27).ToList();