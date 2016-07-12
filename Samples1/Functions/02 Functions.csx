using System;

// (int, int) -> int (-> yields or returns)

int AddTwoIntegers(int a, int b)
{
    var sum = a + b;
    return sum;
}

//can have return a + b;

var sum = AddTwoIntegers(5, 10);
Console.WriteLine(sum);
//capture the result with var sum and it contains it and it acts independently of var sum within the {}


int AddTwoIntegers (int a, int b)
{
    return a + b;
}

var sum = AddTwoIntegers(5, 10);
Console.WriteLine(sum);

