using System;

internal class Overriding_parent_class
{
	public void Afunc()
	{
		Console.WriteLine("\nThis is console write from parent_class");
	}
}

internal class Overriding_child_class : Overriding_parent_class
{
    public new void Afunc()
    {
        Console.WriteLine("This is console write from child_class");
    }
}