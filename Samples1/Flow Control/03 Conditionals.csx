
var x = 15;

if (x <= 20)
{
    Console.WriteLine("x is 20");
}
else if(x == 20)
{
    Console.WriteLine("x is 20");
}
else
{
    Console.WriteLine("X is not 10 or 20");
}

//shorter form

Console.WriteLine(x == 10 ? "x is 10" : "x is not 10");

object o = null();

object o2 = o ?? new object();

var o2;
if (o == null)
{
    o2 == new object();
}
else
{
    o2 = o;
}