using Class_lab;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("\n function loading output: ");
        function_overloading function_overloading_obj = new function_overloading();
        Console.WriteLine(function_overloading_obj.add_func(253, 253));
        Console.WriteLine(function_overloading_obj.add_func(253.02, 253.02));
        Console.WriteLine(function_overloading_obj.multiply(100, 2));
        Console.WriteLine(function_overloading_obj.multiply(22.22, 2.11));

        check_inheri check_inheri_obj = new check_inheri();
        Console.WriteLine("\n Multiple inheritance with inteface: ");
        Console.WriteLine(check_inheri_obj.add(2, 3));
        Console.WriteLine(check_inheri_obj.subtract(2, 3));
        Console.WriteLine(check_inheri_obj.multiplication(2, 3));
        Console.WriteLine(check_inheri_obj.division(2, 3));

        inheri_without_interface_child inheri_without_interface_child_obj = new inheri_without_interface_child();
        Console.WriteLine("\n Output of inheritance without interface");
        Console.WriteLine(inheri_without_interface_child_obj.add(2, 2));
        //Console.WriteLine(inheri_without_interface_child_obj.mul(2, 2));


        Console.ReadKey();
    }
}