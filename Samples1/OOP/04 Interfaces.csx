#r "System.Windows.Forms.dll"

using System;
using System.Windows.Forms;

public interface IGreeter
{  //interface has to be visible, always public.
    void SayHello(string name);
}
//have to be explicit about public
public class ConsoleGreeter
    : IGreeter
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

    public void SayGoodbye(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }
}

public class WindowsGreeter
    :IGreeter
{
    void IGreeter.SayHello(string name)
    {
        MessageBox.Show($"Hello, {name}", "Greetings!");
    }
}

var cg = new ConsoleGreeter();
//cg.SayHello("Dave");

IGreeter wg = new WindowsGreeter();
//wg.SayHello("Pickachu");

public class Person
{
    private readonly IGreeter _greeter;

    public Person(IGreeter greeter)
    {
        _greeter = greeter;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Greet()
    {
        greeter.SayHello($"{FirstName} {LastName}");

    }
}

var p = new Person(cg)
{
    FirstName = "Pikachu",
    LastName = "Pokemon"
};

p.Greet();

