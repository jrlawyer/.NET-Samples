using System.Text;

var firstName = "Jennifer";
var lastName = "Lawyer";

//Concatention

var s1 = firstName + " " + lastName;

var firstName = "James";
var lastName = "Alexander";


var s1 = firstName + " " + lastName;

//StringBuilder
var s2 =
    new System.Text.StringBuilder()
        .Append(firstName)
        .Append(" ")
        .Append(lastName)
        .ToString();

var s2 =
    new StringBuilder()
        .Append(firstName)
        .Append(" ")
        .Append(lastName)
        .ToString();

var s2 =
    new StringBuilder()
    .Append(firstName)
    .Append(" ")
    .Append(lastName)
    .ToString();


//Format String

var s3 = 
   string.Format(
    "{0} {1}",
    firstName,
    lastName
    );

//String Interpolation
var s4 = $"{firstName} {lastName}";

var s5 = $"{firstName} {lastName}";



   