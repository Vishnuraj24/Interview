

//declaring an array

int[] arr = new int[5] { 25, 87, 23, 2, 46 };

//sorting the array
//Array.Sort(arr);

//Printing the largest number in the array
//Console.WriteLine("Largest number in the array: "+arr[arr.Length - 1]);


Console.WriteLine("Before sorting: " + String.Join(",", arr));


//sorting the array using the bubble sort
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1]) //Change the '>' to '<' to sort in the descending
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}


Console.WriteLine("After Sorting: " + String.Join(",", arr));
