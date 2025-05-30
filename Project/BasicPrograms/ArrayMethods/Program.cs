int[] nums = { 17, 19, 2, 14, 23, 45, 32,32, 50 };


//Array.Copy
int[] copynums = new int[9];
Array.Copy(nums, copynums, 4);
Console.WriteLine(string.Join(",", copynums));


//Array.Length
Console.WriteLine(nums.Length);

//Array.Sort
Array.Sort(nums);
Console.WriteLine(string.Join(",",nums));

//BinarySearch;
Console.WriteLine(
Array.BinarySearch(nums, 23));

//Array.Reverse
Array.Reverse(nums);
Console.WriteLine(string.Join(",", nums));

//Array.IndexOf
Console.WriteLine(Array.IndexOf(nums, 9));
/*Returns
Int32
The index of the first occurrence of value in array,
if found; otherwise, the lower bound of the array minus 1.*/

//Array.LastIndexOf
Console.WriteLine(Array.LastIndexOf(nums, 32));

//Array.Exists
//Find the Even numbers in the array
Console.WriteLine(Array.Exists(nums,x => x > 24)); //True

//Array.Find
Console.WriteLine(Array.Find(nums,x => x > 24));    


//Array.FindAll
Console.WriteLine(string.Join(",",Array.FindAll(nums,x => x > 24)));

//Array.Resize()
Array.Resize(ref nums, 5);
Console.WriteLine(string.Join(",",nums));

