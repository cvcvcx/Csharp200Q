using System;

namespace _055
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            int primes = 0;

            for (int i = 2; i < 1000; i++)
            {
                for (index = 2; index < i; index++)
                {
                    if (i % index == 0)
                        break;
                }
                if (index == i)
                {
                    primes++;
                    Console.WriteLine("{0,5}{1}", i, primes % 15 == 0 ? "\n" : "");
                }
            }
            Console.WriteLine("\n2부터 1000 사이의 소수의 개수 {0}개", primes);

        }
    }
}

