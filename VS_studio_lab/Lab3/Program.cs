using System;


internal class Program
{
    private static void Main()
    {
        // Output of Spliting
        Console.WriteLine("Output of Spliting");
        UpdateTimeStamp UpdateTimeStamp_obj = new UpdateTimeStamp();
        UpdateTimeStamp_obj.splitting();


        Console.WriteLine("\nEnter value of a and b.");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        int aa = (int)a;
        
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        int bb = (int)b;


        // Code for overloading 
        Overloading overloading_obj = new Overloading();

        // Calling add method
        Console.WriteLine("\nResult from double add method: " + overloading_obj.add(a, b));
        Console.WriteLine("Result from int add method: " + overloading_obj.add(aa, bb));
        // Calling mutiply method
        Console.WriteLine("Result from double multiply method: " + overloading_obj.multiply(a, b));
        Console.WriteLine("Result from int add method: " + overloading_obj.multiply(aa, bb));


        // Code for inheritance
        Inheritance inheritance_obj = new Inheritance();
        Console.WriteLine("\nResult for multiple inheritance");
        Console.WriteLine("Addition: " + inheritance_obj.Add(a, b));
        Console.WriteLine("Subtraction: " + inheritance_obj.Subtract(a, b));
        Console.WriteLine("Multiplication: " + inheritance_obj.Multiply(a, b));
        Console.WriteLine("Division: " + inheritance_obj.Divide(a, b));


        // Code for Overriding
        Overriding_parent_class Overriding_parent_class_obj = new Overriding_parent_class();
        Overriding_parent_class_obj.Afunc();

        Overriding_child_class Overriding_child_class_obj = new Overriding_child_class();
        Overriding_child_class_obj.Afunc();



        Console.ReadKey();

    }
}