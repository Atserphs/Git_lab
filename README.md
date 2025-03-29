# Introduction
This repository is for storing and documenting the lab report of VB.NET. It includes:
1. VS_studio_lab - It stores console app of different lab.
2. Readme.md - This is a report file for all project. It shows detail explanation and include screenshot image of lab practical. 

## Table of Contents
- [Lab1 - Git Installation, Setup, and Basic Commands](#lab1)
- [Lab2 - Building Console Application](#lab2)


## Lab1 - Git Installation, Setup, and Basic Commands
   ### GIT 
   Git was created by Linus Torvalds in 2005 (Creator of Linux OS). It is a distributed version control 
   system used for keeping track of changes, managing multiple versions of code and collaborating 
   seamlessly across teams. It allows developers to work on their own local copies of a project, while 
   still enabling them to push changes to a shared repository.  <br>
   Git helps to manage and track changes in code by keeping log of commits, branching, showing 
   changes made, and etc. The key features of GIT are, <br>
   - Version Tracking: GIT follows all adjustments done in one record, letting you revert to old 
   releases without trouble. 
   - Collaboration: Different programmers can work on a similar task at the same time without 
   clash. 
   - Branching: You have the option to create distinct branches for new attributes, bug repairs 
   or tests. 
   - Distributed System: Every programmer has an entire version of the project implying that 
   it is decentralized software. 
   - Log of Commits: With this feature, GIT maintains an account of all commit actions 
   (changes), which makes understanding how a project has evolved over time much easier. 
   Basic command of GIT: 
   1. Setup and Configuration
      1. git config –global user.name “user_name” : Sets your name in git. 
      2. git config –global user.email “user@gmail.com” : Sets your email in git. 
   2. Repository Management 
      1. git init : Initializes a new git repository. 
      2. git log : Shows commit details eg.(commit_id, author, date, branch) 
      3. git clone <repository_url> : Clones an existing repository. 
   3. Working with Changes 
      1. git add <file> : Stages a specific file for commit. but if use dot. 
      2. git add . : Stages all changes in stage area. 
      3. git commit -m “commit _message” : Commits staged changes with a message. 
   4. Branching and Merging 
      1. git branch : List all branches. 
      2. git branch <branch_name> : Create a new branch. 
      3. git checkout <branch_name>: Switches to a specified branch also adding.all 
         changes of working branch into staging area of destination branch. 
      4. git switch <branch_name> : Just switches to specified branch. 
      5. dir : Show all directories available in working branch. 
      6. git merge <branch> : Merges a branch into the current branch. 
   5. Viewing Changes and Logs 
      1. git status : Shows the status of changes. 
      2. git log : Displays commit history. 
      3. git diff : Show difference between files. 
   6. Remote Repository 
      1. git remote add origin “repository_url” : Adds a remote repository. 
      2. git push origin -u <branch_name> : First time push branch. 
      3. git push origin <branch_name> : Pushing changes to remote repository. 
      4. git pull origin <branch_name> : Pulls changes from a remote repository. 
   
   
   ### GitHub: 
   GitHub is a web-based platform that uses Git, a version control system, to help developers manage 
   and track changes in their code. GitHub itself provides access control, bug tracking, software 
   feature requests, task management, continuous integration, and wikis for project. Here are some 
   key features of GitHub, 
   - Code Review: Inline commenting and feedback system for improving code quality 
   collaboratively. 
   - Issues Tracking: Organize and track tasks, bugs, and features requests with labels, 
   milestones, and assignees. 
   - Pull Request: A structured way for developers to propose, discuss and review changes 
   before me arranging them. 
   - Actions: Automate workflows like testing, or deployment. 
   - Projects: A Kanban-style project board to visualize workflows and task progress. 
   - Wiki: Serves as a collaborative space for documentation. It’s especially useful for projects 
   that require comprehensive instructions, guidelines, or other important information. 
   - Security: It have Dependabot and Code Scanning to ensure the no security compromised. 
      1. Dependabot: Automatically updates dependencies to reduce security risks. 
      2. Code Scanning: Detect vulnerabilities and potential issues in codebases. 
   - Insights: Provides valuable analytics about your repository to track activity and improve 
   project management 
   - Code Hosting and Sharing: Share codes in repository. Also host static websites directly 
   from repository.

## Lab2 - Building Console Application
### Console Application:
A console application or command-line program is a computer program designed to be used via a text-only user interface, such as a text terminal, the command-line interface of some operating systems, or a text-based interface included with most graphical user interface operating systems, such as Windows.

### Entry Point Method
Entry point method in building a console app is a kind of method where the start and end of the whole app is controlled by the main function.<br>

#### Entrypoint function for following code:
Main function
code:
```
using console1;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello\nAtserphs"); 

        //output of number swap function.
        number_swap number_swap_obj = new number_swap();
        number_swap_obj.number_swap_func();
        //Console.WriteLine(num_obj.number_swap_func());

        //output of check greatest number function.
        int a = 10;
        int b = 20;
        int c = 30;
        check_greatest check_obj = new check_greatest();
        Console.WriteLine("\nGreatest number among 10, 20, and 30 is " + check_obj.check_greatest_number(a,b,c));

        //output of check even or odd function.
        Console.WriteLine("\nEnter any number to check if it is even or odd:");
        string odd_even_num = Console.ReadLine();
        odd_even odd_even_obj = new odd_even();
        Console.WriteLine(odd_even_obj.check_odd_even(int.Parse(odd_even_num)));

        //output of sum of n natural numbers function
        Console.WriteLine("\nEnter any number to sum n natural number:");
        string natural_num = Console.ReadLine();
        sum_n_number sum_n_number_obj = new sum_n_number();
        Console.WriteLine("Sum of natural number to " + odd_even_num + " is " + sum_n_number_obj.sum_n_number_func(int.Parse(natural_num)));
        Console.WriteLine("Sum of natural number using n(n+1)/2 to" + odd_even_num + " is " sum_n_number_obj.sum_n_number_func1(int.Parse(natural_num)) );

        //output of check leap year function
        Console.WriteLine("\nEnter any year to check if it is leap year:");
        string year = Console.ReadLine();
        check_leap_year check_leap_year_obj = new check_leap_year();
        Console.WriteLine(check_leap_year_obj.check_leap_year_func1(int.Parse(year)));
        Console.WriteLine(check_leap_year_obj.check_leap_year_func2(int.Parse(year)));
        Console.WriteLine(check_leap_year_obj.check_leap_year_func3(int.Parse(year)));

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
```

#### Questions:

1. Write a C# Sharp program to print Hello and your name in a separate line. <br>
   Ans: Using console write line command.<br>
   Code:
    ```
    Console.WriteLine("Hello, World!");
    ```

2. Write a C# Sharp program to swap two numbers.<br>
   Ans: using three variables<br>
   code:
   
```
    class number_swap
    {
        public void number_swap_func()
        {
            int a = 18;
            int b = 6;
            int c;

            Console.WriteLine("\nValues before swap:\n a = " + a + " b = " + b);
            c = b;
            b = a;
            a = c;
            Console.WriteLine("Values after swap:\n a = " + a + " b = " + b);
        }
    }
```

3. Write a C# Sharp program to find the largest of three numbers.<br>
   Ans: using if-else if <br>
   code:
   ```
   class check_greatest
   {
       public int check_greatest_number(int a, int b, int c)
       {
           if (a > b & a > c)
           {
               return a;
           }
           else if (b > a & b > c)
           {
               return b;
           }
           else
           {
               return c;
           }
       }
   }
   ```

4. Write a C# Sharp program to check whether a given number is even or odd. <br>
   Ans: using mod by 2 <br>
   code:
   ```
    class odd_even
    {
        public string check_odd_even(int a)
        {
            if (a % 2 == 0)
            {
                return ("even");
            }
            else
            {
                return ("odd");
            }
        }
    }
   ```

5. Write a C# Sharp program that displays the sum of n natural numbers.<br>
   Ans: using <br>
      I. Iteration method<br>
      II. Formula
         $$\frac{n(n+1)}{2}$$ <br>
   code:
   ```
   class sum_n_number
    {
        public int sum_n_number_func(int n)
        {
            int sum = 0;
            for (int i = 1; i<=n; i++)
            {
                sum = sum + i;    
            }
            return sum;
        }

        public int sum_n_number_func1(int n)
        {
            int sum1 = n * (n + 1) / 2;
            return sum1;
        }
    }
   ```

6. Check whether a given year is a leap year or not.<br>
   Ans: using three methods as shown below, <br>
   code:
      ```
          class check_leap_year
       {
           //Method 1
           public string check_leap_year_func1(int year)
           {
               if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
               {
                   return "Leap_year (from func 1)";
               }
               return "Not a Leap year (from func 1)";
           }
           
   
            //Method 2
           public string check_leap_year_func2(int year)
           {
               if(year % 4 == 0)
               {
                   if(year % 100 == 0) 
                   { 
                       if(year % 400 == 0)
                       {
                           return "Leap year (from func 2)";
                       }
                       return "Not a leap year (from func 2)";
                   }
                   return "Leap year (from func 2)";
               }
               return "Not a leap year (from func 2)";
           }
   
           //Method 3
           public string check_leap_year_func3(int year)
           {
               return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? "Leap year (from func 3)" : "Not a leap year (from func 3)";
           }
   
       }
      ```

7. Create an integer array and print sum of array element. <br>
   Ans: using for each loop approach <br>
   Code:
   ```
       class array_index_sum
    {
        public int array_index_sum_func(int[] array)
        {
            int sum = 0;
            foreach (int arr in array)
            {
                sum += arr;
            }
            return sum;

        }
    }
   ```
      
8. Write a C# Sharp program to calculate the factorial of a given number. <br>
   Ans: using normal loop approach,
   Code:
   ```
       class factorial_of_number
    {
        public int factorial_of_number_func(int factorial_number)
        {
            int factorial = 1;
            do
            {
                factorial = factorial * factorial_number;
                factorial_number--;
            } while (factorial_number >= 1);
            return factorial;
        }
    }
   ```

9. Write a program to check if input number is a prime number.<br>
   Ans: using three methods, <br>
   I. Simple Bruteforce Method (loop up to prime number) <br>
   II. Squareroot Half Iteration Method (loop up to square root number of prime number) <br>
   III. Trial Divison Method <br>
   Content link 👍<URL>https://www.geeksforgeeks.org/check-for-prime-number/ </URL>
   <a href="https://www.geeksforgeeks.org/check-for-prime-number/">
   <img src="VS_studio_lab\Lab2\optimized trail divisionmethod.png">
   </a>
   
   Code:
   ```
       class prime_number_check
    {
        //simple bruteforce method of checking prime number
        public string prime_number_check_func(int prime_number)
        {
            if (prime_number <= 1)
            {
                return "Not prime number (bruteforce method)";
            }
    
            for (int i = 2; i < prime_number; i++)
            {
                if (prime_number % i == 0)
                {
                    return "Not prime number (bruteforce method)";
                }
            }
            return "Prime number (bruteforce method)";
          
        }

        //sqrt half iteration method optimized one
        public string prime_number_check_func1(int prime_number)
        {
            if(prime_number == 1)
            {
                return "Not prime number (sqrt method)";
            }

            for (int i = 2; i <= Math.Sqrt(prime_number); i++)
            {
                if(prime_number % i == 0)
                {
                    return "Not prime number (sqrt method)";
                }
            }

            return "Prime number (sqrt method)";
        }

        //trial division method
        public string prime_number_check_func2(int prime_number)
        {
            if(prime_number == 1) { return "Not prime number (trial division method)"; }

            if(prime_number == 2 || prime_number == 3) { return "Not prime number (trial division method)"; }

            if(prime_number % 2 == 0 || prime_number % 3 == 0) { return "Not prime number (trial division method)"; }

            for(int i=5; i <= Math.Sqrt(prime_number); i += 6)
            {
                if(prime_number % i == 0) { return "Not prime number (trial division method)"; }
                
            }

            return "Prime number (trial division method)";
        }
    }
   ```

### Output
Output of above functions is as below,
<img src="VS_studio_lab\Lab2\output.png"

   





