//Find the duplicates in the string

string str = "abccdesaanio";
Dictionary<char,int> dic =  new Dictionary<char,int>();

foreach (char c in str)
{
    if (dic.ContainsKey(c))
    {
        dic[c]++;
    }
    else
    {
        dic[c] = 1;
    }
}

foreach(var item in dic)
{
    //Console.WriteLine($"Item Key : {item.Key} && Item Value : {item.Value}");
    if(item.Value > 1)
    {
        Console.WriteLine(item.Key);
    }
}