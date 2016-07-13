using System;

public class Person
{
    private string _firstName;
    private string _lastName;
    
    //database where you need a person(first name and last name)
    //you'd be entering in required data(first name and last name) to create
    //an instance of this person in said database.  

    public Person(string firstName, string lastName)
    {
        Console.WriteLine("creating a person");
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value.Trim(); }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value.Trim(); }
    }

    //public char MiddleInitial { get; set; }

    public override string ToString()
    {
        //return base.ToString
        return $"{LastName}, {FirstName}";
    }
}


//var p = new Person();
//p.FirstName = "Jennifer";
//p.LastName = "Lawyer";

////Object intialization syntax

//var p2 = new Person
//{
//    FirstName = "Jennifer",
//    LastName = "Lawyer"

//};


var p =
    new Person("Dave", "Fancher");
    {
        MiddleInitial = 'W'
    };

Console.WriteLine(p);
//returns type unless it's overwritten

public class Student
    : Person
{
    public Student(
        int studentId,
        string firstName,
        string lastName)
        : base(firstName, lastName)
    {
        Console.WriteLine("Creating a student");
        StudentId = studentId;
    }

    public int StudentId { get; set; }

    public override string ToString()
    {
        return $"{base} [{StudentId}]";
    }
}

var s = new Student(1, "Nadia", "Francher");
//s.

//WhatIsIt from other example



//Classes Bronze Challenge:

public class MobilePhone
{
    public MobilePhone(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public string Make { get; set; }

    public string Model { get; set; }

    public override string ToString()
    {
        return $"{Make}, {Model}";
    }
}

var p = new MobilePhone("iphone", "5");