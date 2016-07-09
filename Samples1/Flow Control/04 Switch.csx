
var x = 20;

switch (x)
{
    case 10:
        Console.WriteLine("x is 10");
        break;

    case 20:
    case 30:  
        Console.WriteLine("x is 20 or 30");
        break;

    default:
        Console.WriteLine("x is not 10 or 20");
        break;
}

Console.WriteLine("Done");