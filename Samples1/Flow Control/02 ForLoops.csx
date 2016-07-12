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

//string word = "Aword"

var name = new List<string>
{
    "Jen",
    "Bob",
    "Nicole",
    "Sean",
    "Steph",
    "Judy",
    "Tony"
};

foreach (var n in name)
{
if (n=="Jen")
    {
        Console.WriteLine(n.ToUpper());
    }
else if (n.StartsWith("J"))
    {
        Console.WriteLine(n);
    }

}

//for (var x = 0; x < name.Count; x++)
//if (name [x].StartsWith("J"))
//{
//    Console.WriteLine(name [x]);
//}

var myArray = new[] { "Jen", "Bob" };


for (var x = 0; x < myArray.Length; x++)
{
    if (myArray[x][0] == 'J')
    Console.WriteLine(myArray[x]);
}



//foreach(var name in doctors)
//{
//    ConsoleWriteLine($"Name: {name}");
//}

//foreach (var c in "Hello World")
//{
//    Console.WriteLine(c);
//}


////IEnumerable

//var enumerator = doctors.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine($"Item = {enumerator.Current}");
//}

//foreach (var ch in "Hello World")
//{
//    Console.WriteLine(ch);
//}

//var s = "Hello World";
//foreach (char c in s)
//{
//    Console.WriteLine(c);
//}


//char[] chars = new char [3];

//chars[0] = 'H';
//chars[1] = 'e';
//chars[2] = 'l';

//foreach (char c in chars)




//var myArray = new int[2];
//myArray[0] = 1;
//myArray[1] = 2;

//Console.WriteLine(myArray[0]);
//Console.WriteLine(myArray[1]);

//var myArray2 = new[] { 1, 2, 3 };
//myArray.GetType;


//myArray2.Length
//    Console.WriteLine(c);
//} 


