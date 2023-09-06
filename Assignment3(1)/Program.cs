using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MyClass
{
    private int privateField;

    public void SetValue(int value)
    {
        privateField = value;
    }

    public int GetValue()
    {
        return privateField;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        myObject.SetValue(58);

        int value = myObject.GetValue();
        Console.WriteLine("The value is: " + value);
    }
}