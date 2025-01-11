public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Solution 1: Create a copy
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(obj1.MyProperty); // Create a copy

        obj2.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); // Output: 10

        // Solution 2: Using a struct (value type)
        MyStruct obj3 = new MyStruct { MyProperty = 10 };
        MyStruct obj4 = obj3;

        obj4.MyProperty = 20;

        Console.WriteLine(obj3.MyProperty); // Output: 10
    }
}

public struct MyStruct
{
    public int MyProperty { get; set; }
}