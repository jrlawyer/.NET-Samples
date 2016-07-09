using System.Collections.Generic;

var myList = new List<int>();
myList.Add(1);
myList.Add(2);

myList[0];

myList[5] = 4;

var myList2 = new List<int> {1, 2,};

var TV = new[] {"Agents of Shield", "DareDevil", "Voltron"};

var TV2 = new string [3];
TV2[0] = "Agents of Shield";
TV2[1] = "DareDevil";
TV2[2] = "Voltron";

Console.WriteLine(TV2[0]);



var Indy = new List<string>();
Indy.Add("Alexander Rossi");
Indy.Add("Carlos Munoz");
Indy.Add("Josef Newgarden");
Indy.Add("Tony Kanaan");

var indyList = new List<string> { "Alexander Rossi", "Carlos Munoz", "Josef Newgarden", "Tony Kanaan" };
Console.WriteLine (indyList[0]);

