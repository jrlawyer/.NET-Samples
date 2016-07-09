//value types

int i = 0;
short sh = 32767;
long l = 0;
byte by = 225;
char c = 'i';
bool b = true;

decimal d = 7.8m;
double dbl = 7.80f;
float f = 10.8f;

enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

DayOfWeek day = DayOfWeek.Tuesday;

//reference types

object o = new object();

string s = "a string";
string s2 = "This is a \r\nmulti-line string";
string s3 = @"This is a \r\nmulti-line string";

Console.WriteLine(s2);
Console.WriteLine(s3);

object o = null;

System.Nullable<int> nullInt = null;
//int?

var x = 0;
var x = 7.80m;
var x = 7.8f;

 



// comment 1

/*
 * Block comment
 */

//TODO: Refractor this block
