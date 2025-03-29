using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
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

}
