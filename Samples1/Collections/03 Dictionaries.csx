using System.Collections.Generic;

var myDictionary =
    new Dictionary<string, int>();

myDictionary.Add("Sunday", 1);
myDictionary.Add("Monday", 2);

//myDictionary["Sunday"];
//myDictionary["Sunday"] = 7;

var myDictionary2 =
    new Dictionary<string, int>
    {
        {"Sunday", 1 },
        {"Monday", 2 }
    };

myDictionary2["Sunday"]

var award =
    new Dictionary<int, string>();

award.Add(2000, "Gladiator");
award.Add(2001, "A Beautiful Mind");
award.Add(2002, "Chicago");
award.Add(2003, "The Lord of the Rings: Return of the King");
award.Add(2004, "Million Dollar Baby");
award.Add(2005, "Crash");

award[2000];
award[2002];
award[2004];

var age =
    new Dictionary<string, int>();
age.Add("Jen", 33);
age.Add("Bob", 34);

Console.WriteLine(age["Jen"]);



var winners =
    new Dictionary<int, string[]>;
{
    { 2003, new [] {"Crowe", "Russell"} } ;
    { 2005, new[] {"Pitt", "Brad"} };
}

