for(var x = 0; x <= 10; x++)
{
    Console.WriteLine(x);
}

//var doctors = new List<string>
//{
  //  "Strax",
    //"Rose",
    //"Hurt",
   // "Smith"
//};

//for (var x = 0; x < doctors.Count; x++)
//{
  //  var name = doctors[x];
    //Console.WriteLine($"Name: {name}");
//}


foreach(var name in doctors)
{
    ConsoleWriteLine($"Name: {name}");
}

foreach (var c in "Hello World")
{
    Console.WriteLine(c);
}


//IEnumerable

var enumerator = doctors.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine($"Item = {enumerator.Current}");
}

foreach (var ch in "Hello World")
{
    Console.WriteLine(ch);
}

var s = "Hello World";
foreach (char c in s)
{
    Console.WriteLine(c);
}


char[] chars = new char [3];

chars[0] = 'H';
chars[1] = 'e';
chars[2] = 'l';

foreach (char c in chars)




var myArray = new int[2];
myArray[0] = 1;
myArray[1] = 2;

Console.WriteLine(myArray[0]);
Console.WriteLine(myArray[1]);

var myArray2 = new[] { 1, 2, 3 };
myArray.GetType;


myArray2.Length
    Console.WriteLine(c);
} 


