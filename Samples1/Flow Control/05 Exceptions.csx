using System;
using System.Text;

public string Reverse(string str)
{
    if (str.Length == 0)
    {
        throw new ArgumentException("Nothing to Reverse");
    }
    var reversed = new StringBuilder();

    for (var p = str.Length - 1; p >= 0; p--)
    {
        reversed.Append(str[p]);
    }
    return reversed.ToString();
}

try
{
    var reversed = Reverse(null);
    Console.WriteLine(reversed);
}
catch (ArgumentException ex)
{
    Console.WriteLine("String was empty");
    throw; 
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred{ex}");
}
finally
{
    Console.WriteLine("Done");
}