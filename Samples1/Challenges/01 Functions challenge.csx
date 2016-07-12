using System;
using System.Linq;

void FizzBuzz()
{
    for(var x = 1; x <= 100; x++)
    {
        if (x % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (x % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (x % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(x);
        } 

    }
}

FizzBuzz();

string GetFizzBuzzValue(int x)
{
    if (x % 15 == 0)
    {
        return "FizzBuzz";
    }

    else if (x % 3 == 0)
    {
        return "Fizz";
    }
    else if (x % 5 == 0)
    {
        return "Buzz";
    }
    
    return x.ToString();
    
}

void FizzBuzz()
{
        for (var x = 1; x <= 100; x++)
    {
        var fb=GetFizzBuzzValue(x);
        Console.WriteLine(fb);
    }  
}

FizzBuzz();


Enumerable
    .Range(1, 100)
    .Select(GetFizzBuzzValue)
    .ToList()
    .ForEach(Console.WriteLine);