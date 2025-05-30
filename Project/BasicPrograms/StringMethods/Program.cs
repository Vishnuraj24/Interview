string str = "Hello";

//Length of the string 
Console.WriteLine($"String length : {str.Length}"); // Output: 5

//Substring
Console.WriteLine($"Substring : {str.Substring(0, 3)}");

//IndexOf
Console.WriteLine("Index of h: " + str.IndexOf('h',StringComparison.CurrentCultureIgnoreCase));

//Replace
string str2 = " Hello World! How are you doing man ";
Console.WriteLine(str2.Replace("man","vishnuraj"));

//Trim vs Replace
Console.WriteLine(str2.Trim());
Console.WriteLine("Replacing the white spaces: "+str2.Replace(" ", ""));

//ToUpper and ToLower

Console.WriteLine(str2.ToUpper());
Console.WriteLine(str2.ToLower());

//split
string str3 = "a,b,c";
string[] parts = str3.Split(',');
Console.WriteLine(string.Join("-", parts)); // Output: a-b-c


//Startswith and Endwith
string mail = "v-abhay@ntdev.microsoft.com";
bool flag = mail.Split('@')[1].EndsWith("microsoft.com");
Console.WriteLine(flag);


//String.Contains()

Console.WriteLine(str2.Contains("wor",StringComparison.CurrentCultureIgnoreCase));


string a = "hello";
string b = "HELLO";
Console.WriteLine(a.Equals(b));             // False
Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // True


string s1 = "";
string s2 = "  ";

Console.WriteLine(string.IsNullOrEmpty(s1));        // True
Console.WriteLine(string.IsNullOrWhiteSpace(s2));   // True

