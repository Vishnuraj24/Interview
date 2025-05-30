//Reverse a string with the for loop

//Method 1: Using a for loop
string str = "vishnuraj";

string res = "";

for(int i = str.Length - 1; i >= 0; i--)
{
    res+= str[i];
}

Console.WriteLine(res);

//Reverse a string with the methods
//Method 2: Using Array.Reverse()

char[] chararr = str.ToCharArray();

Array.Reverse(chararr);

Console.WriteLine(String.Join("",chararr));


//Method 3: Using a LINQ

string reversestr = new string(str.Reverse().ToArray());

Console.WriteLine(reversestr);

