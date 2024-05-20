static string[] FilterShortStrings(string[] strings)
{
    string[] result = new string[strings.Length];
    int index = 0;
    
    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            result[index] = str;
            index++;
        }
    }
    
    return result;
}

Console.WriteLine("Строки длиной <= 3 символа:");
foreach (string str in resultStrings)
{
    if (str != null)
    {
        Console.WriteLine(str);
    }
}