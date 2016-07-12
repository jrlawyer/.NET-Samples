//Encapsulation

public class myClass
{
    private string _value = "";

    public string Value
    {
        get { return _value; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _value = value;
            }
            else
            {
                throw new ArgumentException("Value is required");
            }
        }
    }

    public int AddTwoIntegers(int a, int b)
    {
        return a + b;
    }
    
}

var mc = new myClass();
mc.Value = "Hello!";
mc.AddTwoIntegers(5, 10);


var mc2 = new MyClass();

//Inheritance

var mc2 = new myClass();
mc2.ToString();

//Polymorphism

string WhatIsIt(object o)
{
    if (o is MyClass) return "MyClass";
    if (o is string) return "string";

    return "Object";
}

WhatIsIt(mc);
WhatIsIt("Hello");
WhatIsIt(new object());
WhatIsIt(null);






