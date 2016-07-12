using System;
using System.Collections.Generic;

//setup the class
public class MobilePhone
{
    //constructor
    public MobilePhone(string make, string model)
    {
        Make = make;
        Model = model;
    }
    //properties
    public string Make { get; set; }
    public string Model { get; set; }


    public override string ToString()
    {
        return $"{Make} {Model}";
    }
}
    var myPhone = new MobilePhone("iPhone", "5");
    Console.WriteLine(myPhone);

var phones =
    new Dictionary<string, MobilePhone>
    {
        'Kevin", new MobilePhone("iPhone", "6")};
    };

foreach(var p in phones)
    Console.WriteLin(${p.key
