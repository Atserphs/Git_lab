using console1;

internal class Program
{
    private static void Main()
    {
        //Console.WriteLine("Hello, World!"); // 

        /*/output of number swap function.
        number_swap num_obj = new number_swap();
        Console.WriteLine(num_obj.number_swap1());

        //output of check greatest number function.
        int a = 10;
        int b = 20;
        int c = 30;
        check_greatest check_obj = new check_greatest();
        Console.WriteLine("Greatest number among 10, 20, and 30 is " + check_obj.check_greatest_number(a,b,c));

        //output of check even or odd function.
        Console.WriteLine("\nEnter any number to check if it is even or odd:");
        string odd_even_num = Console.ReadLine();
        odd_even odd_even_obj = new odd_even();
        Console.WriteLine(odd_even_obj.check_odd_even(int.Parse(odd_even_num)));

        //outpur of sum of n natural numbers function
        Console.WriteLine("\nEnter any number to sum n natural number:");
        string natural_num = Console.ReadLine();
        sum_n_number sum_n_number_obj = new sum_n_number();
        Console.WriteLine("Sum of natural number to " + odd_even_num + " is " + sum_n_number_obj.sum_n_number_func(int.Parse(natural_num)));

        //output of check leap year function
        Console.WriteLine("\nEnter any year to check if it is leap year:");
        string year = Console.ReadLine();
        check_leap_year check_leap_year_obj = new check_leap_year();
        Console.WriteLine(check_leap_year_obj.check_leap_year_func1(int.Parse(year)));
        Console.WriteLine(check_leap_year_obj.check_leap_year_func2(int.Parse(year)));
        Console.WriteLine(check_leap_year_obj.check_leap_year_func3(int.Parse(year)));*/

        //output of array sum
        int[] array_for_sum = [1, 2, 3, 4, 5, 6];
        array_index_sum array_index_sum_obj = new array_index_sum();
        Console.WriteLine("\nSum of array is " + array_index_sum_obj.array_index_sum_func(array_for_sum));

        //output of factorial of number
        Console.WriteLine("\nEnter any number to calculate its factorial:");
        string factorial_number = Console.ReadLine();
        factorial_of_number factorial_of_number_obj = new factorial_of_number();
        Console.WriteLine(factorial_of_number_obj.factorial_of_number_func(int.Parse(factorial_number)));

        //output of check prime number func
        Console.WriteLine("\nEnter any number to check if it is prime number:");
        string prime_number = Console.ReadLine();
        prime_number_check prime_number_check_obj = new prime_number_check();
        Console.WriteLine(prime_number_check_obj.prime_number_check_func(int.Parse(prime_number)));
        Console.WriteLine(prime_number_check_obj.prime_number_check_func1(int.Parse(prime_number)));
        Console.WriteLine(prime_number_check_obj.prime_number_check_func2(int.Parse(prime_number)));


        //to hold app
        Console.ReadKey();

    }
}